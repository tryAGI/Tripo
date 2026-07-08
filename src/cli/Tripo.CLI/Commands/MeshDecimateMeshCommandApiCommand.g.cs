#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Tripo.CLI.Commands;

internal static partial class MeshDecimateMeshCommandApiCommand
{
    private static Option<string> InputOption { get; } = new(
        name: @"--input")
    {
        Description = @"Model source. Accepts task_id or file_token.",
        Required = true,
    };

    private static Option<string?> Model { get; } = new(
        name: @"--model")
    {
        Description = @"Decimation model version.",
    };

    private static Option<int?> FaceLimit { get; } = new(
        name: @"--face-limit")
    {
        Description = @"Target polycount, in the range 1000-20000.",
    };

    private static Option<bool?> Quad { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--quad",
        description: @"Output a quad mesh.");

    private static Option<global::System.Collections.Generic.IList<string>?> PartNames { get; } = new(
        name: @"--part-names")
    {
        Description = @"List of part names to decimate.",
    };

    private static Option<bool?> Bake { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--bake",
        description: @"Bake textures onto the low-poly model.");
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
        var command = new Command(@"decimate-mesh", @"Decimate or retopologize a 3D model");
                        command.Options.Add(InputOption);
                        command.Options.Add(Model);
                        command.Options.Add(FaceLimit);
                        command.Options.Add(Quad);
                        command.Options.Add(PartNames);
                        command.Options.Add(Bake);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Tripo.DecimateMeshRequest>(
                            parseResult,
                            RequestInput,
                            RequestJson,
                            RequestFile,
                            global::Tripo.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var input = parseResult.GetRequiredValue(InputOption);
                        var model = CliRuntime.WasSpecified(parseResult, Model) ? parseResult.GetValue(Model) : (__requestBase is { } __ModelBaseValue ? __ModelBaseValue.Model : default);
                        var faceLimit = CliRuntime.WasSpecified(parseResult, FaceLimit) ? parseResult.GetValue(FaceLimit) : (__requestBase is { } __FaceLimitBaseValue ? __FaceLimitBaseValue.FaceLimit : default);
                        var quad = CliRuntime.WasSpecified(parseResult, Quad) ? parseResult.GetValue(Quad) : (__requestBase is { } __QuadBaseValue ? __QuadBaseValue.Quad : default);
                        var partNames = CliRuntime.WasSpecified(parseResult, PartNames) ? parseResult.GetValue(PartNames) : (__requestBase is { } __PartNamesBaseValue ? __PartNamesBaseValue.PartNames : default);
                        var bake = CliRuntime.WasSpecified(parseResult, Bake) ? parseResult.GetValue(Bake) : (__requestBase is { } __BakeBaseValue ? __BakeBaseValue.Bake : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Mesh.DecimateMeshAsync(
                                    input: input,
                                    model: model,
                                    faceLimit: faceLimit,
                                    quad: quad,
                                    partNames: partNames,
                                    bake: bake,
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