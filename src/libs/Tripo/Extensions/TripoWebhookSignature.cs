using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace Tripo;

/// <summary>
/// Verifies signatures sent in the <c>Tripo-Webhook-Signature</c> header.
/// </summary>
public static class TripoWebhookSignature
{
    private static readonly TimeSpan DefaultTolerance = TimeSpan.FromMinutes(5);

    /// <summary>
    /// Verifies a Tripo webhook signature against the exact request body bytes.
    /// </summary>
    /// <param name="payload">The unmodified request body.</param>
    /// <param name="signatureHeader">The value of the <c>Tripo-Webhook-Signature</c> header.</param>
    /// <param name="secret">The webhook signing secret, including its <c>whsec_</c> prefix.</param>
    /// <param name="tolerance">The allowed difference from the current time. Defaults to five minutes.</param>
    /// <param name="timeProvider">The clock used for replay protection.</param>
    /// <returns><see langword="true" /> when a current, matching V1 signature is present.</returns>
    public static bool Verify(
        ReadOnlySpan<byte> payload,
        string signatureHeader,
        string secret,
        TimeSpan? tolerance = null,
        TimeProvider? timeProvider = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(secret);

        if (string.IsNullOrWhiteSpace(signatureHeader))
        {
            return false;
        }

        var allowedAge = tolerance ?? DefaultTolerance;
        if (allowedAge < TimeSpan.Zero)
        {
            throw new ArgumentOutOfRangeException(nameof(tolerance), tolerance, "Tolerance cannot be negative.");
        }

        string? timestampText = null;
        List<string> signatures = [];

        foreach (var component in signatureHeader.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries))
        {
            var separator = component.IndexOf('=', StringComparison.Ordinal);
            if (separator <= 0 || separator == component.Length - 1)
            {
                return false;
            }

            var name = component[..separator];
            var value = component[(separator + 1)..];

            if (string.Equals(name, "t", StringComparison.Ordinal))
            {
                timestampText = value;
            }
            else if (string.Equals(name, "v1", StringComparison.Ordinal))
            {
                signatures.Add(value);
            }
        }

        if (timestampText is null || signatures.Count == 0 ||
            !long.TryParse(timestampText, NumberStyles.None, CultureInfo.InvariantCulture, out var timestamp))
        {
            return false;
        }

        DateTimeOffset signedAt;
        try
        {
            signedAt = DateTimeOffset.FromUnixTimeSeconds(timestamp);
        }
        catch (ArgumentOutOfRangeException)
        {
            return false;
        }

        var now = (timeProvider ?? TimeProvider.System).GetUtcNow();
        if ((now - signedAt).Duration() > allowedAge)
        {
            return false;
        }

        var prefix = Encoding.UTF8.GetBytes(timestampText + ".");
        var signedPayload = GC.AllocateUninitializedArray<byte>(prefix.Length + payload.Length);
        prefix.CopyTo(signedPayload, 0);
        payload.CopyTo(signedPayload.AsSpan(prefix.Length));

        var secretBytes = Encoding.UTF8.GetBytes(secret);
        try
        {
            var expected = HMACSHA256.HashData(secretBytes, signedPayload);

            foreach (var signature in signatures)
            {
                byte[] actual;
                try
                {
                    actual = Convert.FromHexString(signature);
                }
                catch (FormatException)
                {
                    continue;
                }

                if (actual.Length == expected.Length && CryptographicOperations.FixedTimeEquals(actual, expected))
                {
                    return true;
                }
            }

            return false;
        }
        finally
        {
            CryptographicOperations.ZeroMemory(secretBytes);
        }
    }

    /// <summary>
    /// Verifies a Tripo webhook signature against an unmodified UTF-8 request body.
    /// </summary>
    public static bool Verify(
        string payload,
        string signatureHeader,
        string secret,
        TimeSpan? tolerance = null,
        TimeProvider? timeProvider = null)
    {
        ArgumentNullException.ThrowIfNull(payload);

        return Verify(Encoding.UTF8.GetBytes(payload), signatureHeader, secret, tolerance, timeProvider);
    }
}
