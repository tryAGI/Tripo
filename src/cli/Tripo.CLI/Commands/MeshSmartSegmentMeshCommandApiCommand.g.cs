#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Tripo.CLI.Commands;

internal static partial class MeshSmartSegmentMeshCommandApiCommand
{
    private static Option<string> SegType { get; } = new(
        name: @"--seg-type")
    {
        Description = @"Segmentation type: image or model.",
        Required = true,
    };

    private static Option<string> InputOption { get; } = new(
        name: @"--input")
    {
        Description = @"Input source: file_token or public URL.",
        Required = true,
    };

    private static Option<string?> Granularity { get; } = new(
        name: @"--granularity")
    {
        Description = @"Segmentation granularity: coarse, medium, or fine.",
    };

    private static Option<string?> Hint { get; } = new(
        name: @"--hint")
    {
        Description = @"Optional hint to help identify parts to segment.",
    };

    private static Option<global::System.Collections.Generic.IList<double>?> Transform { get; } = new(
        name: @"--transform")
    {
        Description = @"Required when seg_type=model. Column-major 4x4 transform matrix with 16 floats.",
    };
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
        var command = new Command(@"smart-segment-mesh", @"Run the end-to-end smart segmentation pipeline");
                        command.Options.Add(SegType);
                        command.Options.Add(InputOption);
                        command.Options.Add(Granularity);
                        command.Options.Add(Hint);
                        command.Options.Add(Transform);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Tripo.SmartSegmentMeshRequest>(
                            parseResult,
                            RequestInput,
                            RequestJson,
                            RequestFile,
                            global::Tripo.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var segType = parseResult.GetRequiredValue(SegType);
                        var input = parseResult.GetRequiredValue(InputOption);
                        var granularity = CliRuntime.WasSpecified(parseResult, Granularity) ? parseResult.GetValue(Granularity) : (__requestBase is { } __GranularityBaseValue ? __GranularityBaseValue.Granularity : default);
                        var hint = CliRuntime.WasSpecified(parseResult, Hint) ? parseResult.GetValue(Hint) : (__requestBase is { } __HintBaseValue ? __HintBaseValue.Hint : default);
                        var transform = CliRuntime.WasSpecified(parseResult, Transform) ? parseResult.GetValue(Transform) : (__requestBase is { } __TransformBaseValue ? __TransformBaseValue.Transform : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Mesh.SmartSegmentMeshAsync(
                                    segType: segType,
                                    input: input,
                                    granularity: granularity,
                                    hint: hint,
                                    transform: transform,
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