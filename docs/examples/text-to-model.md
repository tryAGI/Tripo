# Text To Model



This example assumes `using Tripo;` is in scope and `apiKey` contains your Tripo API key.

```csharp
using var api = new TripoClient(apiKey);

TaskCreatedResponse response = await api.ThreeDGeneration.TextToModelAsync(new TextToModelRequest
{
    Prompt = "Generate a stylized explorer character",
    Model = "v3.1-20260211",
    Texture = true,
});

Console.WriteLine($"Code: {response.Code}");
Console.WriteLine($"TaskId: {response.Data.TaskId}");

await Task.Delay(TimeSpan.FromMinutes(1));

TaskResponse taskResponse = await api.Tasks.GetTaskAsync(response.Data.TaskId);

Console.WriteLine($"Code: {taskResponse.Code}");
Console.WriteLine($"Status: {taskResponse.Data.Status}");
Console.WriteLine($"RenderedImage: {taskResponse.Data.Output?.RenderedImageUrl}");
Console.WriteLine($"Model: {taskResponse.Data.Output?.ModelUrl}");
```