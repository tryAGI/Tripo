namespace Tripo.IntegrationTests;

using AsyncTask = System.Threading.Tasks.Task;

public partial class Tests
{
    [TestMethod]
    [TestCategory("LiveSmoke")]
    public async AsyncTask V3Smoke()
    {
        if (!string.Equals(
                Environment.GetEnvironmentVariable("TRIPO_RUN_LIVE_SMOKE"),
                "true",
                StringComparison.OrdinalIgnoreCase))
        {
            throw new AssertInconclusiveException(
                "Set TRIPO_RUN_LIVE_SMOKE=true to run the credit-consuming V3 smoke test.");
        }

        using var timeout = new CancellationTokenSource(TimeSpan.FromMinutes(10));
        using var api = GetAuthenticatedClient();

        BalanceResponse balanceBefore = await api.Account.GetBalanceAsync(cancellationToken: timeout.Token);
        balanceBefore.Code.Should().Be(0);

        var png = Convert.FromBase64String(
            "iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAQAAAC1HAwCAAAAC0lEQVR42mP8/x8AAusB9Y9Zl1sAAAAASUVORK5CYII=");
        FileResponse upload = await api.Files.UploadFileAsync(
            png,
            "tripo-v3-smoke.png",
            cancellationToken: timeout.Token);
        upload.Code.Should().Be(0);
        upload.Data.FileToken.Should().NotBeNullOrWhiteSpace();

        TaskCreatedResponse created = await api.ThreeDGeneration.TextToModelAsync(
            new TextToModelRequest
            {
                Prompt = "A simple untextured cube for an API health check",
                Model = "v2.5-20250123",
                Texture = false,
                Pbr = false,
                ExportUv = false,
                ReturnMultiview = false,
                RenderSequence = false,
                RenderVideo = false,
            },
            cancellationToken: timeout.Token);
        created.Code.Should().Be(0);
        created.Data.TaskId.Should().NotBeNullOrWhiteSpace();

        TaskResponse task;
        do
        {
            task = await api.Tasks.GetTaskAsync(created.Data.TaskId, cancellationToken: timeout.Token);
            task.Code.Should().Be(0);

            Console.WriteLine($"Task {created.Data.TaskId}: {task.Data.Status} ({task.Data.Progress ?? 0}%)");

            if (task.Data.Status is not ("success" or "failed" or "cancelled"))
            {
                await AsyncTask.Delay(TimeSpan.FromSeconds(3), timeout.Token);
            }
        }
        while (task.Data.Status is not ("success" or "failed" or "cancelled"));

        task.Data.Status.Should().Be(
            "success",
            $"task failed with error {task.Data.ErrorCode}: {task.Data.ErrorMessage}");
        task.Data.Output.Should().NotBeNull();
        task.Data.Output!.ModelUrl.Should().NotBeNullOrWhiteSpace();

        BalanceResponse balanceAfter = await api.Account.GetBalanceAsync(cancellationToken: timeout.Token);
        balanceAfter.Code.Should().Be(0);

        Console.WriteLine($"Credits before: {balanceBefore.Data.Balance}");
        Console.WriteLine($"Credits after: {balanceAfter.Data.Balance}");
        Console.WriteLine($"Balance difference: {balanceBefore.Data.Balance - balanceAfter.Data.Balance}");
        Console.WriteLine($"Task credits consumed: {task.Data.CreditsConsumed}");
    }
}
