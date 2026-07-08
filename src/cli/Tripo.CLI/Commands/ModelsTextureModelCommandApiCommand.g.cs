#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Tripo.CLI.Commands;

internal static partial class ModelsTextureModelCommandApiCommand
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
        Description = @"AI model version.",
    };

    private static Option<int?> TextureSeed { get; } = new(
        name: @"--texture-seed")
    {
        Description = @"Random seed for texture generation.",
    };

    private static Option<string?> TextureQuality { get; } = new(
        name: @"--texture-quality")
    {
        Description = @"Texture quality, such as standard, detailed, or extreme.",
    };

    private static Option<bool?> Pbr { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--pbr",
        description: @"Enable PBR materials.");
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
        var command = new Command(@"texture-model", @"Regenerate texture maps for an existing model");
                        command.Options.Add(InputOption);
                        command.Options.Add(Model);
                        command.Options.Add(TextureSeed);
                        command.Options.Add(TextureQuality);
                        command.Options.Add(Pbr);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Tripo.TextureModelRequest>(
                            parseResult,
                            RequestInput,
                            RequestJson,
                            RequestFile,
                            global::Tripo.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var input = parseResult.GetRequiredValue(InputOption);
                        var model = CliRuntime.WasSpecified(parseResult, Model) ? parseResult.GetValue(Model) : (__requestBase is { } __ModelBaseValue ? __ModelBaseValue.Model : default);
                        var textureSeed = CliRuntime.WasSpecified(parseResult, TextureSeed) ? parseResult.GetValue(TextureSeed) : (__requestBase is { } __TextureSeedBaseValue ? __TextureSeedBaseValue.TextureSeed : default);
                        var textureQuality = CliRuntime.WasSpecified(parseResult, TextureQuality) ? parseResult.GetValue(TextureQuality) : (__requestBase is { } __TextureQualityBaseValue ? __TextureQualityBaseValue.TextureQuality : default);
                        var pbr = CliRuntime.WasSpecified(parseResult, Pbr) ? parseResult.GetValue(Pbr) : (__requestBase is { } __PbrBaseValue ? __PbrBaseValue.Pbr : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Models.TextureModelAsync(
                                    input: input,
                                    model: model,
                                    textureSeed: textureSeed,
                                    textureQuality: textureQuality,
                                    pbr: pbr,
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