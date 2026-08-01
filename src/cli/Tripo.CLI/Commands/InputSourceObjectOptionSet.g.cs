#nullable enable

using System.CommandLine;

namespace Tripo.CLI.Commands;

internal sealed record InputSourceObjectOptionSet(
    Option<string?> Type,
                     Option<string?> Url,
                     Option<string?> FileToken)
{
    public static InputSourceObjectOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new InputSourceObjectOptionSet(
                        Type: new Option<string?>($"--{normalizedPrefix}type")
                {
                    Description = @"File extension such as png, jpeg, webp, glb, or fbx.",
                },
                Url: new Option<string?>($"--{normalizedPrefix}url")
                {
                    Description = @"Public URL input.",
                },
                FileToken: new Option<string?>($"--{normalizedPrefix}file-token")
                {
                    Description = @"Uploaded file token.",
                }
        );
    }
}