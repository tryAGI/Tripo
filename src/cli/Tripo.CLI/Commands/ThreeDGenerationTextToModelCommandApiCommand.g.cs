#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Tripo.CLI.Commands;

internal static partial class ThreeDGenerationTextToModelCommandApiCommand
{
    private static Option<string> Prompt { get; } = new(
        name: @"--prompt")
    {
        Description = @"Text prompt, up to 1024 characters.",
        Required = true,
    };

    private static Option<string?> NegativePrompt { get; } = new(
        name: @"--negative-prompt")
    {
        Description = @"Negative prompt, up to 255 characters.",
    };

    private static Option<int?> ImageSeed { get; } = new(
        name: @"--image-seed")
    {
        Description = @"Random seed for the text-to-image stage.",
    };

    private static Option<string?> Model { get; } = new(
        name: @"--model")
    {
        Description = @"AI model version, for example tripo-p1, tripo-turbo, tripo-v3.1, tripo-v3.0, tripo-v2.5, or tripo-v2.0.",
    };

    private static Option<int?> ModelSeed { get; } = new(
        name: @"--model-seed")
    {
        Description = @"Random seed for geometry generation.",
    };

    private static Option<int?> FaceLimit { get; } = new(
        name: @"--face-limit")
    {
        Description = @"Maximum polycount for the output.",
    };

    private static Option<bool?> Texture { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--texture",
        description: @"Enable texture maps.");

    private static Option<bool?> Pbr { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--pbr",
        description: @"Enable PBR materials. When enabled, texture is forced to true.");

    private static Option<int?> TextureSeed { get; } = new(
        name: @"--texture-seed")
    {
        Description = @"Random seed for texture generation.",
    };

    private static Option<string?> TextureQuality { get; } = new(
        name: @"--texture-quality")
    {
        Description = @"Texture quality, such as standard, detailed, or extreme. Extreme can produce 8K textures where supported.",
    };

    private static Option<string?> GeometryQuality { get; } = new(
        name: @"--geometry-quality")
    {
        Description = @"Geometry quality, such as standard or detailed.",
    };

    private static Option<bool?> AutoSize { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--auto-size",
        description: @"Automatically scale the model to real-world dimensions in meters.");

    private static Option<bool?> Quad { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--quad",
        description: @"Output a quad mesh where supported.");

    private static Option<bool?> SmartLowPoly { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--smart-low-poly",
        description: @"Generate a low-poly model with hand-crafted topology style where supported.");

    private static Option<bool?> GenerateParts { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--generate-parts",
        description: @"Generate editable segmented parts where supported.");

    private static Option<string?> Compress { get; } = new(
        name: @"--compress")
    {
        Description = @"Compression type, such as geometry for meshopt compression.",
    };

    private static Option<bool?> ExportUv { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--export-uv",
        description: @"Control UV unwrapping where supported.");
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
        var command = new Command(@"text-to-model", @"Generate a 3D model from a text prompt");
                        command.Options.Add(Prompt);
                        command.Options.Add(NegativePrompt);
                        command.Options.Add(ImageSeed);
                        command.Options.Add(Model);
                        command.Options.Add(ModelSeed);
                        command.Options.Add(FaceLimit);
                        command.Options.Add(Texture);
                        command.Options.Add(Pbr);
                        command.Options.Add(TextureSeed);
                        command.Options.Add(TextureQuality);
                        command.Options.Add(GeometryQuality);
                        command.Options.Add(AutoSize);
                        command.Options.Add(Quad);
                        command.Options.Add(SmartLowPoly);
                        command.Options.Add(GenerateParts);
                        command.Options.Add(Compress);
                        command.Options.Add(ExportUv);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Tripo.TextToModelRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Tripo.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var prompt = parseResult.GetRequiredValue(Prompt);
                        var negativePrompt = CliRuntime.WasSpecified(parseResult, NegativePrompt) ? parseResult.GetValue(NegativePrompt) : (__requestBase is { } __NegativePromptBaseValue ? __NegativePromptBaseValue.NegativePrompt : default);
                        var imageSeed = CliRuntime.WasSpecified(parseResult, ImageSeed) ? parseResult.GetValue(ImageSeed) : (__requestBase is { } __ImageSeedBaseValue ? __ImageSeedBaseValue.ImageSeed : default);
                        var model = CliRuntime.WasSpecified(parseResult, Model) ? parseResult.GetValue(Model) : (__requestBase is { } __ModelBaseValue ? __ModelBaseValue.Model : default);
                        var modelSeed = CliRuntime.WasSpecified(parseResult, ModelSeed) ? parseResult.GetValue(ModelSeed) : (__requestBase is { } __ModelSeedBaseValue ? __ModelSeedBaseValue.ModelSeed : default);
                        var faceLimit = CliRuntime.WasSpecified(parseResult, FaceLimit) ? parseResult.GetValue(FaceLimit) : (__requestBase is { } __FaceLimitBaseValue ? __FaceLimitBaseValue.FaceLimit : default);
                        var texture = CliRuntime.WasSpecified(parseResult, Texture) ? parseResult.GetValue(Texture) : (__requestBase is { } __TextureBaseValue ? __TextureBaseValue.Texture : default);
                        var pbr = CliRuntime.WasSpecified(parseResult, Pbr) ? parseResult.GetValue(Pbr) : (__requestBase is { } __PbrBaseValue ? __PbrBaseValue.Pbr : default);
                        var textureSeed = CliRuntime.WasSpecified(parseResult, TextureSeed) ? parseResult.GetValue(TextureSeed) : (__requestBase is { } __TextureSeedBaseValue ? __TextureSeedBaseValue.TextureSeed : default);
                        var textureQuality = CliRuntime.WasSpecified(parseResult, TextureQuality) ? parseResult.GetValue(TextureQuality) : (__requestBase is { } __TextureQualityBaseValue ? __TextureQualityBaseValue.TextureQuality : default);
                        var geometryQuality = CliRuntime.WasSpecified(parseResult, GeometryQuality) ? parseResult.GetValue(GeometryQuality) : (__requestBase is { } __GeometryQualityBaseValue ? __GeometryQualityBaseValue.GeometryQuality : default);
                        var autoSize = CliRuntime.WasSpecified(parseResult, AutoSize) ? parseResult.GetValue(AutoSize) : (__requestBase is { } __AutoSizeBaseValue ? __AutoSizeBaseValue.AutoSize : default);
                        var quad = CliRuntime.WasSpecified(parseResult, Quad) ? parseResult.GetValue(Quad) : (__requestBase is { } __QuadBaseValue ? __QuadBaseValue.Quad : default);
                        var smartLowPoly = CliRuntime.WasSpecified(parseResult, SmartLowPoly) ? parseResult.GetValue(SmartLowPoly) : (__requestBase is { } __SmartLowPolyBaseValue ? __SmartLowPolyBaseValue.SmartLowPoly : default);
                        var generateParts = CliRuntime.WasSpecified(parseResult, GenerateParts) ? parseResult.GetValue(GenerateParts) : (__requestBase is { } __GeneratePartsBaseValue ? __GeneratePartsBaseValue.GenerateParts : default);
                        var compress = CliRuntime.WasSpecified(parseResult, Compress) ? parseResult.GetValue(Compress) : (__requestBase is { } __CompressBaseValue ? __CompressBaseValue.Compress : default);
                        var exportUv = CliRuntime.WasSpecified(parseResult, ExportUv) ? parseResult.GetValue(ExportUv) : (__requestBase is { } __ExportUvBaseValue ? __ExportUvBaseValue.ExportUv : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ThreeDGeneration.TextToModelAsync(
                                    prompt: prompt,
                                    negativePrompt: negativePrompt,
                                    imageSeed: imageSeed,
                                    model: model,
                                    modelSeed: modelSeed,
                                    faceLimit: faceLimit,
                                    texture: texture,
                                    pbr: pbr,
                                    textureSeed: textureSeed,
                                    textureQuality: textureQuality,
                                    geometryQuality: geometryQuality,
                                    autoSize: autoSize,
                                    quad: quad,
                                    smartLowPoly: smartLowPoly,
                                    generateParts: generateParts,
                                    compress: compress,
                                    exportUv: exportUv,
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