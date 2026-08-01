#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Tripo.CLI.Commands;

internal static partial class ModelsTextureModelCommandApiCommand
{
    private static Option<string?> InputOption { get; } = new(
        name: @"--input")
    {
        Description = @"Model source. Accepts task_id, file_token, or URL.",
    };

    private static Option<string?> Model { get; } = new(
        name: @"--model")
    {
        Description = @"Texture model version, v3.0-20250812 or v2.5-20250123. Defaults to v3.0-20250812.",
    };

    private static Option<string?> OriginalModelTaskId { get; } = new(
        name: @"--original-model-task-id")
    {
        Description = @"V2-compatible source model task ID.",
    };

    private static Option<global::Tripo.TexturePrompt?> TexturePrompt { get; } = new(
        name: @"--texture-prompt")
    {
        Description = @"",
    };

    private static Option<bool?> Texture { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--texture",
        description: @"Enable texture maps.");

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

    private static Option<string?> TextureAlignment { get; } = new(
        name: @"--texture-alignment")
    {
        Description = @"Texture alignment priority, original_image or geometry.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> PartNames { get; } = new(
        name: @"--part-names")
    {
        Description = @"Names of segmented parts to texture.",
    };

    private static Option<string?> Compress { get; } = new(
        name: @"--compress")
    {
        Description = @"Compression type, such as geometry.",
    };

    private static Option<bool?> Bake { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--bake",
        description: @"Bake advanced material effects into base textures.");

    private static Option<bool?> ReturnMultiview { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--return-multiview",
        description: @"Include generated multiview images in the task output.");
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
                        command.Options.Add(OriginalModelTaskId);
                        command.Options.Add(TexturePrompt);
                        command.Options.Add(Texture);
                        command.Options.Add(TextureSeed);
                        command.Options.Add(TextureQuality);
                        command.Options.Add(Pbr);
                        command.Options.Add(TextureAlignment);
                        command.Options.Add(PartNames);
                        command.Options.Add(Compress);
                        command.Options.Add(Bake);
                        command.Options.Add(ReturnMultiview);
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
                        var input = CliRuntime.WasSpecified(parseResult, InputOption) ? parseResult.GetValue(InputOption) : (__requestBase is { } __InputBaseValue ? __InputBaseValue.Input : default);
                        var model = CliRuntime.WasSpecified(parseResult, Model) ? parseResult.GetValue(Model) : (__requestBase is { } __ModelBaseValue ? __ModelBaseValue.Model : default);
                        var originalModelTaskId = CliRuntime.WasSpecified(parseResult, OriginalModelTaskId) ? parseResult.GetValue(OriginalModelTaskId) : (__requestBase is { } __OriginalModelTaskIdBaseValue ? __OriginalModelTaskIdBaseValue.OriginalModelTaskId : default);
                        var texturePrompt = CliRuntime.WasSpecified(parseResult, TexturePrompt) ? parseResult.GetValue(TexturePrompt) : (__requestBase is { } __TexturePromptBaseValue ? __TexturePromptBaseValue.TexturePrompt : default);
                        var texture = CliRuntime.WasSpecified(parseResult, Texture) ? parseResult.GetValue(Texture) : (__requestBase is { } __TextureBaseValue ? __TextureBaseValue.Texture : default);
                        var textureSeed = CliRuntime.WasSpecified(parseResult, TextureSeed) ? parseResult.GetValue(TextureSeed) : (__requestBase is { } __TextureSeedBaseValue ? __TextureSeedBaseValue.TextureSeed : default);
                        var textureQuality = CliRuntime.WasSpecified(parseResult, TextureQuality) ? parseResult.GetValue(TextureQuality) : (__requestBase is { } __TextureQualityBaseValue ? __TextureQualityBaseValue.TextureQuality : default);
                        var pbr = CliRuntime.WasSpecified(parseResult, Pbr) ? parseResult.GetValue(Pbr) : (__requestBase is { } __PbrBaseValue ? __PbrBaseValue.Pbr : default);
                        var textureAlignment = CliRuntime.WasSpecified(parseResult, TextureAlignment) ? parseResult.GetValue(TextureAlignment) : (__requestBase is { } __TextureAlignmentBaseValue ? __TextureAlignmentBaseValue.TextureAlignment : default);
                        var partNames = CliRuntime.WasSpecified(parseResult, PartNames) ? parseResult.GetValue(PartNames) : (__requestBase is { } __PartNamesBaseValue ? __PartNamesBaseValue.PartNames : default);
                        var compress = CliRuntime.WasSpecified(parseResult, Compress) ? parseResult.GetValue(Compress) : (__requestBase is { } __CompressBaseValue ? __CompressBaseValue.Compress : default);
                        var bake = CliRuntime.WasSpecified(parseResult, Bake) ? parseResult.GetValue(Bake) : (__requestBase is { } __BakeBaseValue ? __BakeBaseValue.Bake : default);
                        var returnMultiview = CliRuntime.WasSpecified(parseResult, ReturnMultiview) ? parseResult.GetValue(ReturnMultiview) : (__requestBase is { } __ReturnMultiviewBaseValue ? __ReturnMultiviewBaseValue.ReturnMultiview : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Models.TextureModelAsync(
                                    input: input,
                                    model: model,
                                    originalModelTaskId: originalModelTaskId,
                                    texturePrompt: texturePrompt,
                                    texture: texture,
                                    textureSeed: textureSeed,
                                    textureQuality: textureQuality,
                                    pbr: pbr,
                                    textureAlignment: textureAlignment,
                                    partNames: partNames,
                                    compress: compress,
                                    bake: bake,
                                    returnMultiview: returnMultiview,
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