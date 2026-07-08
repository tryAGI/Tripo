/*
order: 20
title: Text To Model
slug: text-to-model
*/

namespace Tripo.IntegrationTests;

using Task = System.Threading.Tasks.Task;

public partial class Tests
{
    [TestMethod]
    public async Task TextToModel()
    {
        using var api = GetAuthenticatedClient();

        TaskCreatedResponse response = await api.ThreeDGeneration.TextToModelAsync(new TextToModelRequest
        {
            Prompt = "Generate a stylized explorer character",
            Model = "tripo-v3.1",
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
    }
}
