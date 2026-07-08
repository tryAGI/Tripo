#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Tripo.CLI.Commands;

internal static partial class ImageGenerationTextToImageCommandApiCommand
{
    private static Option<string> Prompt { get; } = new(
        name: @"--prompt")
    {
        Description = @"Text prompt, up to 1024 characters.",
        Required = true,
    };

    private static Option<string?> Model { get; } = new(
        name: @"--model")
    {
        Description = @"Image model, for example seedream_v5, seedream_v4, gemini-2.5-flash, gemini-3-pro, gemini-3.1-flash, chat_image_1, chat_image_1.5, or chat_image_2.",
    };

    private static Option<string?> Template { get; } = new(
        name: @"--template")
    {
        Description = @"Template name, such as asset_extraction, character_completion, t_pose, head_extraction, 3d_enhance, variants, print_clay, or figure.",
    };

    private static Option<bool?> TPose { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--t-pose",
        description: @"Convert to T-pose.");

    private static Option<bool?> SketchToRender { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--sketch-to-render",
        description: @"Convert a sketch to a rendered image.");
      private static Option<string?> Input { get; } = new(@"--input")
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
        var command = new Command(@"text-to-image", @"Generate an image from a text prompt");
                        command.Options.Add(Prompt);
                        command.Options.Add(Model);
                        command.Options.Add(Template);
                        command.Options.Add(TPose);
                        command.Options.Add(SketchToRender);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Tripo.TextToImageRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Tripo.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var prompt = parseResult.GetRequiredValue(Prompt);
                        var model = CliRuntime.WasSpecified(parseResult, Model) ? parseResult.GetValue(Model) : (__requestBase is { } __ModelBaseValue ? __ModelBaseValue.Model : default);
                        var template = CliRuntime.WasSpecified(parseResult, Template) ? parseResult.GetValue(Template) : (__requestBase is { } __TemplateBaseValue ? __TemplateBaseValue.Template : default);
                        var tPose = CliRuntime.WasSpecified(parseResult, TPose) ? parseResult.GetValue(TPose) : (__requestBase is { } __TPoseBaseValue ? __TPoseBaseValue.TPose : default);
                        var sketchToRender = CliRuntime.WasSpecified(parseResult, SketchToRender) ? parseResult.GetValue(SketchToRender) : (__requestBase is { } __SketchToRenderBaseValue ? __SketchToRenderBaseValue.SketchToRender : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ImageGeneration.TextToImageAsync(
                                    prompt: prompt,
                                    model: model,
                                    template: template,
                                    tPose: tPose,
                                    sketchToRender: sketchToRender,
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