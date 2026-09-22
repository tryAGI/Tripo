namespace Tripo.IntegrationTests;

using System.Text.Json;

[TestClass]
public sealed class V3SchemaTests
{
    [TestMethod]
    public void TextureV35ControlsSerializeForEveryTextureEntryPoint()
    {
        var requests = new (string Name, string Json, string VersionField)[]
        {
            ("text-to-model", new TextToModelRequest
            {
                Prompt = "A ceramic vase",
                Model = "v3.1-20260211",
                TextureVersion = "v3.5-20260815",
                TextureQuality = "fast",
                Delight = false,
            }.ToJson(), "texture_version"),
            ("image-to-model", new ImageToModelRequest
            {
                Input = "file_abc123",
                Model = "v3.1-20260211",
                TextureVersion = "v3.5-20260815",
                TextureQuality = "fast",
                Delight = false,
            }.ToJson(), "texture_version"),
            ("multiview-to-model", new MultiviewToModelRequest
            {
                Model = "v3.1-20260211",
                TextureVersion = "v3.5-20260815",
                TextureQuality = "fast",
                Delight = false,
            }.ToJson(), "texture_version"),
            ("texture-model", new TextureModelRequest
            {
                Input = "task_abc123",
                Model = "v3.5-20260815",
                TextureQuality = "fast",
                Delight = false,
            }.ToJson(), "model"),
        };

        foreach (var (name, json, versionField) in requests)
        {
            using var document = JsonDocument.Parse(json);
            var root = document.RootElement;
            root.GetProperty(versionField).GetString().Should().Be("v3.5-20260815", name);
            root.GetProperty("texture_quality").GetString().Should().Be("fast", name);
            root.GetProperty("delight").GetBoolean().Should().BeFalse(name);
        }
    }

    [TestMethod]
    public void TextureV35DefaultsRemainServerControlled()
    {
        using var generation = JsonDocument.Parse(new TextToModelRequest
        {
            Prompt = "A ceramic vase",
            Model = "v3.1-20260211",
        }.ToJson());
        using var texture = JsonDocument.Parse(new TextureModelRequest
        {
            Input = "task_abc123",
        }.ToJson());

        generation.RootElement.TryGetProperty("texture_version", out _).Should().BeFalse();
        generation.RootElement.TryGetProperty("delight", out _).Should().BeFalse();
        generation.RootElement.TryGetProperty("texture_quality", out _).Should().BeFalse();
        texture.RootElement.TryGetProperty("model", out _).Should().BeFalse();
        texture.RootElement.TryGetProperty("delight", out _).Should().BeFalse();
    }

    [TestMethod]
    public void TaskResponseDeserializesV3FailureFields()
    {
        const string json = """
            {
              "code": 0,
              "status": "success",
              "data": {
                "task_id": "0196f4ce-82a8-7ddb-970f-6a940e17c830",
                "status": "failed",
                "error_code": 2008,
                "error_message": "Input rejected by content moderation."
              }
            }
            """;

        var response = TaskResponse.FromJson(json);

        response.Should().NotBeNull();
        response!.Status.Should().Be("success");
        response.Data.Status.Should().Be("failed");
        response.Data.ErrorCode.Should().Be(2008);
        response.Data.ErrorMessage.Should().Be("Input rejected by content moderation.");
    }

    [TestMethod]
    public void TaskResponseDeserializesV3OutputNames()
    {
        const string json = """
            {
              "code": 0,
              "data": {
                "task_id": "0196f4ce-82a8-7ddb-970f-6a940e17c830",
                "status": "success",
                "output": {
                  "model_url": "https://example.com/model.glb",
                  "rendered_image_url": "https://example.com/render.png",
                  "generated_image_url": "https://example.com/generated.png"
                }
              }
            }
            """;

        var response = TaskResponse.FromJson(json);

        response.Should().NotBeNull();
        response!.Data.Output.Should().NotBeNull();
        response.Data.Output!.ModelUrl.Should().Be("https://example.com/model.glb");
        response.Data.Output.RenderedImageUrl.Should().Be("https://example.com/render.png");
        response.Data.Output.GeneratedImageUrl.Should().Be("https://example.com/generated.png");
    }

    [TestMethod]
    public void TaskListResponseDeserializesTaskMapAndMissedIds()
    {
        const string json = """
            {
              "code": 0,
              "data": {
                "tasks": {
                  "0196f4ce-82a8-7ddb-970f-6a940e17c830": {
                    "task_id": "0196f4ce-82a8-7ddb-970f-6a940e17c830",
                    "status": "running",
                    "progress": 60
                  }
                },
                "missed": ["missing-task-id"]
              }
            }
            """;

        var response = TaskListResponse.FromJson(json);

        response.Should().NotBeNull();
        response!.Data.Tasks.Should().ContainKey("0196f4ce-82a8-7ddb-970f-6a940e17c830");
        response.Data.Tasks["0196f4ce-82a8-7ddb-970f-6a940e17c830"].Status.Should().Be("running");
        response.Data.Missed.Should().ContainSingle().Which.Should().Be("missing-task-id");
    }
}
