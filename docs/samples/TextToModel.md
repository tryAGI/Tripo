```csharp
using var api = new TripoClient(apiKey);

SuccessTask response = await api.CreateTaskAsync(new CreateTaskRequestVariant1
{
    Type = CreateTaskRequestVariant1Type.TextToModel,
    Prompt = "Generate some girl face",
});

Console.WriteLine($"Code: {response.Code}");
Console.WriteLine($"TaskId: {response.Data.TaskId}");

await Task.Delay(TimeSpan.FromMinutes(1));

GetTaskResponse taskResponse = await api.GetTaskAsync(response.Data.TaskId);

Console.WriteLine($"Code: {taskResponse.Code}");
Console.WriteLine($"Status: {taskResponse.Data.Status}");
Console.WriteLine($"RenderedImage: {taskResponse.Data.Output.RenderedImage}");;
Console.WriteLine($"Model: {taskResponse.Data.Output.Model}");
Console.WriteLine($"PbrModel: {taskResponse.Data.Output.PbrModel}");
Console.WriteLine($"BaseModel: {taskResponse.Data.Output.BaseModel}");
```