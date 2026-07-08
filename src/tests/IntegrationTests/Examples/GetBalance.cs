/*
order: 10
title: Get Balance
slug: get-balance
*/

namespace Tripo.IntegrationTests;

using Task = System.Threading.Tasks.Task;

public partial class Tests
{
    [TestMethod]
    public async Task GetBalance()
    {
        using var api = GetAuthenticatedClient();

        BalanceResponse response = await api.Account.GetBalanceAsync();
        
        Console.WriteLine($"Code: {response.Code}");
        Console.WriteLine($"Balance: {response.Data.Balance}");
        Console.WriteLine($"Frozen: {response.Data.Frozen}");
    }
}
