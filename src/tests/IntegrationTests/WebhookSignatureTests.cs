using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace Tripo.IntegrationTests;

[TestClass]
public sealed class WebhookSignatureTests
{
    private const string Secret = "whsec_test_secret";
    private static readonly DateTimeOffset CurrentTime = DateTimeOffset.FromUnixTimeSeconds(1_800_000_000);
    private static readonly TimeProvider Clock = new FixedTimeProvider(CurrentTime);

    [TestMethod]
    public void VerifyAcceptsValidSignature()
    {
        const string payload = "{\"data\":{\"task_id\":\"task_123\"}}";
        var signature = CreateSignature(payload, CurrentTime.ToUnixTimeSeconds(), Secret);

        TripoWebhookSignature.Verify(payload, signature, Secret, timeProvider: Clock).Should().BeTrue();
    }

    [TestMethod]
    public void VerifyAcceptsMatchingSignatureDuringKeyRotation()
    {
        const string payload = "{\"data\":{\"status\":\"success\"}}";
        var timestamp = CurrentTime.ToUnixTimeSeconds();
        var signature = CreateSignature(payload, timestamp, Secret);
        var rotatedHeader = $"t={timestamp.ToString(CultureInfo.InvariantCulture)},v1={new string('0', 64)},{signature[(signature.IndexOf(',', StringComparison.Ordinal) + 1)..]}";

        TripoWebhookSignature.Verify(payload, rotatedHeader, Secret, timeProvider: Clock).Should().BeTrue();
    }

    [TestMethod]
    public void VerifyRejectsTamperedPayload()
    {
        const string payload = "{\"data\":{\"status\":\"success\"}}";
        var signature = CreateSignature(payload, CurrentTime.ToUnixTimeSeconds(), Secret);

        TripoWebhookSignature.Verify("{\"data\":{\"status\":\"failed\"}}", signature, Secret, timeProvider: Clock)
            .Should().BeFalse();
    }

    [TestMethod]
    public void VerifyRejectsExpiredTimestamp()
    {
        const string payload = "{}";
        var timestamp = CurrentTime.AddMinutes(-6).ToUnixTimeSeconds();
        var signature = CreateSignature(payload, timestamp, Secret);

        TripoWebhookSignature.Verify(payload, signature, Secret, timeProvider: Clock).Should().BeFalse();
    }

    [TestMethod]
    public void VerifyRejectsMalformedHeader()
    {
        TripoWebhookSignature.Verify("{}", "v1=not-hex", Secret, timeProvider: Clock).Should().BeFalse();
    }

    private static string CreateSignature(string payload, long timestamp, string secret)
    {
        var timestampText = timestamp.ToString(CultureInfo.InvariantCulture);
        var key = Encoding.UTF8.GetBytes(secret);
        var signedPayload = Encoding.UTF8.GetBytes($"{timestampText}.{payload}");
        var signature = Convert.ToHexStringLower(HMACSHA256.HashData(key, signedPayload));

        return $"t={timestampText},v1={signature}";
    }

    private sealed class FixedTimeProvider(DateTimeOffset currentTime) : TimeProvider
    {
        public override DateTimeOffset GetUtcNow() => currentTime;
    }
}
