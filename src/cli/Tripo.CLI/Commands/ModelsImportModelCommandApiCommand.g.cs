#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Tripo.CLI.Commands;

internal static partial class ModelsImportModelCommandApiCommand
{
    private static Option<string?> InputOption { get; } = new(
        name: @"--input")
    {
        Description = @"Model file source. Accepts file_token or URL. Supported formats include GLB, GLTF, FBX, OBJ, and STL.",
    };
    private static readonly InputSourceObjectOptionSet FileOptions = InputSourceObjectOptionSet.Create(@"file");
      private static Option<string?> RequestInput { get; } = new(@"--request-input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::Tripo.TaskCreatedResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Tripo.TaskCreatedResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"import-model", @"Import an external 3D model file");
                        command.Options.Add(InputOption);                        command.Options.Add(FileOptions.Type);
                        command.Options.Add(FileOptions.Url);
                        command.Options.Add(FileOptions.FileToken);
          command.Options.Add(RequestInput);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(RequestInput) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --request-input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Tripo.ImportModelRequest>(
                            parseResult,
                            RequestInput,
                            RequestJson,
                            RequestFile,
                            global::Tripo.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var input = CliRuntime.WasSpecified(parseResult, InputOption) ? parseResult.GetValue(InputOption) : (__requestBase is { } __InputBaseValue ? __InputBaseValue.Input : default);

                        var __FileBase = __requestBase is { } __FileBaseValue ? __FileBaseValue.File : default;                        var fileType = CliRuntime.WasSpecified(parseResult, FileOptions.Type) ? parseResult.GetValue(FileOptions.Type) : (__FileBase is { } __FiletypeBaseValue ? __FiletypeBaseValue.Type : default);
                        var fileUrl = CliRuntime.WasSpecified(parseResult, FileOptions.Url) ? parseResult.GetValue(FileOptions.Url) : (__FileBase is { } __FileurlBaseValue ? __FileurlBaseValue.Url : default);
                        var fileFileToken = CliRuntime.WasSpecified(parseResult, FileOptions.FileToken) ? parseResult.GetValue(FileOptions.FileToken) : (__FileBase is { } __FilefileTokenBaseValue ? __FilefileTokenBaseValue.FileToken : default);
                        var __FileSpecified = CliRuntime.WasSpecified(parseResult, FileOptions.Type) || CliRuntime.WasSpecified(parseResult, FileOptions.Url) || CliRuntime.WasSpecified(parseResult, FileOptions.FileToken);
                        var file =
                            __FileSpecified || __FileBase is not null
                                ? new global::Tripo.InputSourceObject
                                {
	                                Type = fileType,
                                Url = fileUrl,
                                FileToken = fileFileToken,

                                }
                                : __FileBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Models.ImportModelAsync(
                                    input: input,
                                    file: file,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Tripo.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}