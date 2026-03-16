namespace Tripo.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static TripoClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("TRIPO_API_KEY") ??
            throw new AssertInconclusiveException("TRIPO_API_KEY environment variable is not found.");

        var api = new TripoClient(apiKey);
        
        return api;
    }
}
