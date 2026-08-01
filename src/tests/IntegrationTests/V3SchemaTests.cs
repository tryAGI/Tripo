namespace Tripo.IntegrationTests;

[TestClass]
public sealed class V3SchemaTests
{
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
