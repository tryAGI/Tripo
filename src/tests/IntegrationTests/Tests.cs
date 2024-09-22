namespace Tripo.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static TripoApi GetAuthenticatedApi()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("TRIPO_API_KEY") ??
            throw new AssertInconclusiveException("TRIPO_API_KEY environment variable is not found.");

        var api = new TripoApi(apiKey);
        
        return api;
    }
}
