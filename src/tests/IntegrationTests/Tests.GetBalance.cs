namespace Tripo.IntegrationTests;

using Task = System.Threading.Tasks.Task;

public partial class Tests
{
    [TestMethod]
    public async Task GetBalance()
    {
        using var api = GetAuthenticatedApi();

        GetBalanceResponse response = await api.GetBalanceAsync();
        
        Console.WriteLine($"Code: {response.Code}");
        Console.WriteLine($"Balance: {response.Data.Data.Balance}");
        Console.WriteLine($"Frozen: {response.Data.Data.Frozen}");
    }
}
