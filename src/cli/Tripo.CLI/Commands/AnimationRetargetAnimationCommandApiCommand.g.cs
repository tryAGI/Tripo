#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Tripo.CLI.Commands;

internal static partial class AnimationRetargetAnimationCommandApiCommand
{
    private static Option<string> InputOption { get; } = new(
        name: @"--input")
    {
        Description = @"task_id of the rigged model.",
        Required = true,
    };

    private static Option<string?> Animation { get; } = new(
        name: @"--animation")
    {
        Description = @"Single preset animation identifier. Mutually exclusive with animations.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> Animations { get; } = new(
        name: @"--animations")
    {
        Description = @"List of multiple preset animation identifiers. Mutually exclusive with animation.",
    };

    private static Option<string?> OutFormat { get; } = new(
        name: @"--out-format")
    {
        Description = @"Output format, such as glb or fbx.",
    };

    private static Option<bool?> BakeAnimation { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--bake-animation",
        description: @"Bake the animation into the model. Only effective for glb output.");

    private static Option<bool?> ExportWithGeometry { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--export-with-geometry",
        description: @"Export with geometry included.");

    private static Option<bool?> AnimateInPlace { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--animate-in-place",
        description: @"Play the animation in place without displacement.");
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
        var command = new Command(@"retarget-animation", @"Apply preset animations to a rigged 3D model");
                        command.Options.Add(InputOption);
                        command.Options.Add(Animation);
                        command.Options.Add(Animations);
                        command.Options.Add(OutFormat);
                        command.Options.Add(BakeAnimation);
                        command.Options.Add(ExportWithGeometry);
                        command.Options.Add(AnimateInPlace);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Tripo.RetargetAnimationRequest>(
                            parseResult,
                            RequestInput,
                            RequestJson,
                            RequestFile,
                            global::Tripo.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var input = parseResult.GetRequiredValue(InputOption);
                        var animation = CliRuntime.WasSpecified(parseResult, Animation) ? parseResult.GetValue(Animation) : (__requestBase is { } __AnimationBaseValue ? __AnimationBaseValue.Animation : default);
                        var animations = CliRuntime.WasSpecified(parseResult, Animations) ? parseResult.GetValue(Animations) : (__requestBase is { } __AnimationsBaseValue ? __AnimationsBaseValue.Animations : default);
                        var outFormat = CliRuntime.WasSpecified(parseResult, OutFormat) ? parseResult.GetValue(OutFormat) : (__requestBase is { } __OutFormatBaseValue ? __OutFormatBaseValue.OutFormat : default);
                        var bakeAnimation = CliRuntime.WasSpecified(parseResult, BakeAnimation) ? parseResult.GetValue(BakeAnimation) : (__requestBase is { } __BakeAnimationBaseValue ? __BakeAnimationBaseValue.BakeAnimation : default);
                        var exportWithGeometry = CliRuntime.WasSpecified(parseResult, ExportWithGeometry) ? parseResult.GetValue(ExportWithGeometry) : (__requestBase is { } __ExportWithGeometryBaseValue ? __ExportWithGeometryBaseValue.ExportWithGeometry : default);
                        var animateInPlace = CliRuntime.WasSpecified(parseResult, AnimateInPlace) ? parseResult.GetValue(AnimateInPlace) : (__requestBase is { } __AnimateInPlaceBaseValue ? __AnimateInPlaceBaseValue.AnimateInPlace : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Animation.RetargetAnimationAsync(
                                    input: input,
                                    animation: animation,
                                    animations: animations,
                                    outFormat: outFormat,
                                    bakeAnimation: bakeAnimation,
                                    exportWithGeometry: exportWithGeometry,
                                    animateInPlace: animateInPlace,
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