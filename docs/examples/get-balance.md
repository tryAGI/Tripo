# Get Balance



This example assumes `using Tripo;` is in scope and `apiKey` contains your Tripo API key.

```csharp
using var api = new TripoClient(apiKey);

GetBalanceResponse response = await api.GetBalanceAsync();

Console.WriteLine($"Code: {response.Code}");
Console.WriteLine($"Balance: {response.Data.Data.Balance}");
Console.WriteLine($"Frozen: {response.Data.Data.Frozen}");
```