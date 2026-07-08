#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Tripo.CLI.Commands;

internal static partial class AnimationRigModelCommandApiCommand
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
        Description = @"Auto rigging model version, such as rig-v2.0 or rig-v1.0.",
    };

    private static Option<string?> RigType { get; } = new(
        name: @"--rig-type")
    {
        Description = @"Rig type, such as biped, quadruped, hexapod, octopod, avian, serpentine, or aquatic.",
    };

    private static Option<string?> Spec { get; } = new(
        name: @"--spec")
    {
        Description = @"Rigging specification, such as tripo or mixamo.",
    };

    private static Option<string?> OutFormat { get; } = new(
        name: @"--out-format")
    {
        Description = @"Output format, such as glb or fbx.",
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
        var command = new Command(@"rig-model", @"Rig a 3D model");
                        command.Options.Add(InputOption);
                        command.Options.Add(Model);
                        command.Options.Add(RigType);
                        command.Options.Add(Spec);
                        command.Options.Add(OutFormat);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Tripo.RigModelRequest>(
                            parseResult,
                            RequestInput,
                            RequestJson,
                            RequestFile,
                            global::Tripo.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var input = parseResult.GetRequiredValue(InputOption);
                        var model = CliRuntime.WasSpecified(parseResult, Model) ? parseResult.GetValue(Model) : (__requestBase is { } __ModelBaseValue ? __ModelBaseValue.Model : default);
                        var rigType = CliRuntime.WasSpecified(parseResult, RigType) ? parseResult.GetValue(RigType) : (__requestBase is { } __RigTypeBaseValue ? __RigTypeBaseValue.RigType : default);
                        var spec = CliRuntime.WasSpecified(parseResult, Spec) ? parseResult.GetValue(Spec) : (__requestBase is { } __SpecBaseValue ? __SpecBaseValue.Spec : default);
                        var outFormat = CliRuntime.WasSpecified(parseResult, OutFormat) ? parseResult.GetValue(OutFormat) : (__requestBase is { } __OutFormatBaseValue ? __OutFormatBaseValue.OutFormat : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Animation.RigModelAsync(
                                    input: input,
                                    model: model,
                                    rigType: rigType,
                                    spec: spec,
                                    outFormat: outFormat,
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