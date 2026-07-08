#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Tripo.CLI.Commands;

internal static partial class MeshSegmentMeshCommandApiCommand
{
    private static Option<string> InputOption { get; } = new(
        name: @"--input")
    {
        Description = @"Model source. Accepts task_id, file_token, or URL.",
        Required = true,
    };

    private static Option<string?> Model { get; } = new(
        name: @"--model")
    {
        Description = @"Segmentation model version, such as v1.0-20250506 or v2.0-20260430.",
    };

    private static Option<string?> SegmentationGranularity { get; } = new(
        name: @"--segmentation-granularity")
    {
        Description = @"v2 only. Granularity, such as simple, balanced, or detailed.",
    };

    private static Option<bool?> SplitByConnectivity { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--split-by-connectivity",
        description: @"v2 only. Whether to split by connected components.");

    private static Option<string?> RefImage { get; } = new(
        name: @"--ref-image")
    {
        Description = @"v2 only. Reference image as file_token or URL.",
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
        var command = new Command(@"segment-mesh", @"Perform semantic segmentation on a 3D model");
                        command.Options.Add(InputOption);
                        command.Options.Add(Model);
                        command.Options.Add(SegmentationGranularity);
                        command.Options.Add(SplitByConnectivity);
                        command.Options.Add(RefImage);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Tripo.SegmentMeshRequest>(
                            parseResult,
                            RequestInput,
                            RequestJson,
                            RequestFile,
                            global::Tripo.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var input = parseResult.GetRequiredValue(InputOption);
                        var model = CliRuntime.WasSpecified(parseResult, Model) ? parseResult.GetValue(Model) : (__requestBase is { } __ModelBaseValue ? __ModelBaseValue.Model : default);
                        var segmentationGranularity = CliRuntime.WasSpecified(parseResult, SegmentationGranularity) ? parseResult.GetValue(SegmentationGranularity) : (__requestBase is { } __SegmentationGranularityBaseValue ? __SegmentationGranularityBaseValue.SegmentationGranularity : default);
                        var splitByConnectivity = CliRuntime.WasSpecified(parseResult, SplitByConnectivity) ? parseResult.GetValue(SplitByConnectivity) : (__requestBase is { } __SplitByConnectivityBaseValue ? __SplitByConnectivityBaseValue.SplitByConnectivity : default);
                        var refImage = CliRuntime.WasSpecified(parseResult, RefImage) ? parseResult.GetValue(RefImage) : (__requestBase is { } __RefImageBaseValue ? __RefImageBaseValue.RefImage : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Mesh.SegmentMeshAsync(
                                    input: input,
                                    model: model,
                                    segmentationGranularity: segmentationGranularity,
                                    splitByConnectivity: splitByConnectivity,
                                    refImage: refImage,
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