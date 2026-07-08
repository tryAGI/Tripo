#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Tripo.CLI.Commands;

internal static partial class ModelsConvertModelCommandApiCommand
{
    private static Option<string> InputOption { get; } = new(
        name: @"--input")
    {
        Description = @"Model source. Accepts task_id or file_token.",
        Required = true,
    };

    private static Option<string> Format { get; } = new(
        name: @"--format")
    {
        Description = @"Target format, such as GLTF, USDZ, FBX, OBJ, STL, or 3MF.",
        Required = true,
    };

    private static Option<bool?> Quad { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--quad",
        description: @"Quad remeshing.");

    private static Option<bool?> ForceSymmetry { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--force-symmetry",
        description: @"Force symmetry. Only valid when quad is true.");

    private static Option<int?> FaceLimit { get; } = new(
        name: @"--face-limit")
    {
        Description = @"Maximum polycount. If omitted, the original face count is preserved.",
    };

    private static Option<bool?> FlattenBottom { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--flatten-bottom",
        description: @"Flatten bottom.");

    private static Option<double?> FlattenBottomThreshold { get; } = new(
        name: @"--flatten-bottom-threshold")
    {
        Description = @"Flattening depth threshold.",
    };

    private static Option<int?> TextureSize { get; } = new(
        name: @"--texture-size")
    {
        Description = @"Diffuse texture size in pixels.",
    };

    private static Option<string?> TextureFormat { get; } = new(
        name: @"--texture-format")
    {
        Description = @"Texture format, such as BMP, DPX, HDR, JPEG, PNG, TARGA, TIFF, or WEBP.",
    };

    private static Option<bool?> Bake { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--bake",
        description: @"Bake advanced materials into base textures.");

    private static Option<bool?> PackUv { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--pack-uv",
        description: @"Pack all UVs into a unified layout.");

    private static Option<bool?> ExportVertexColors { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--export-vertex-colors",
        description: @"Include vertex colors. Only valid for OBJ and GLTF formats.");

    private static Option<bool?> PivotToCenterBottom { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--pivot-to-center-bottom",
        description: @"Move the pivot to the bottom center.");

    private static Option<double?> ScaleFactor { get; } = new(
        name: @"--scale-factor")
    {
        Description = @"Scale factor.",
    };

    private static Option<bool?> WithAnimation { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--with-animation",
        description: @"Include skeleton and animation data.");

    private static Option<bool?> AnimateInPlace { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--animate-in-place",
        description: @"In-place animation.");

    private static Option<global::System.Collections.Generic.IList<string>?> PartNames { get; } = new(
        name: @"--part-names")
    {
        Description = @"Names of parts to export, from mesh/segment data.",
    };

    private static Option<string?> ExportOrientation { get; } = new(
        name: @"--export-orientation")
    {
        Description = @"Export orientation, such as -x, -y, or +y.",
    };

    private static Option<string?> FbxPreset { get; } = new(
        name: @"--fbx-preset")
    {
        Description = @"FBX preset for compatibility, such as blender, 3dsmax, or mixamo.",
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
        var command = new Command(@"convert-model", @"Convert a 3D model to another format");
                        command.Options.Add(InputOption);
                        command.Options.Add(Format);
                        command.Options.Add(Quad);
                        command.Options.Add(ForceSymmetry);
                        command.Options.Add(FaceLimit);
                        command.Options.Add(FlattenBottom);
                        command.Options.Add(FlattenBottomThreshold);
                        command.Options.Add(TextureSize);
                        command.Options.Add(TextureFormat);
                        command.Options.Add(Bake);
                        command.Options.Add(PackUv);
                        command.Options.Add(ExportVertexColors);
                        command.Options.Add(PivotToCenterBottom);
                        command.Options.Add(ScaleFactor);
                        command.Options.Add(WithAnimation);
                        command.Options.Add(AnimateInPlace);
                        command.Options.Add(PartNames);
                        command.Options.Add(ExportOrientation);
                        command.Options.Add(FbxPreset);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Tripo.ConvertModelRequest>(
                            parseResult,
                            RequestInput,
                            RequestJson,
                            RequestFile,
                            global::Tripo.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var input = parseResult.GetRequiredValue(InputOption);
                        var format = parseResult.GetRequiredValue(Format);
                        var quad = CliRuntime.WasSpecified(parseResult, Quad) ? parseResult.GetValue(Quad) : (__requestBase is { } __QuadBaseValue ? __QuadBaseValue.Quad : default);
                        var forceSymmetry = CliRuntime.WasSpecified(parseResult, ForceSymmetry) ? parseResult.GetValue(ForceSymmetry) : (__requestBase is { } __ForceSymmetryBaseValue ? __ForceSymmetryBaseValue.ForceSymmetry : default);
                        var faceLimit = CliRuntime.WasSpecified(parseResult, FaceLimit) ? parseResult.GetValue(FaceLimit) : (__requestBase is { } __FaceLimitBaseValue ? __FaceLimitBaseValue.FaceLimit : default);
                        var flattenBottom = CliRuntime.WasSpecified(parseResult, FlattenBottom) ? parseResult.GetValue(FlattenBottom) : (__requestBase is { } __FlattenBottomBaseValue ? __FlattenBottomBaseValue.FlattenBottom : default);
                        var flattenBottomThreshold = CliRuntime.WasSpecified(parseResult, FlattenBottomThreshold) ? parseResult.GetValue(FlattenBottomThreshold) : (__requestBase is { } __FlattenBottomThresholdBaseValue ? __FlattenBottomThresholdBaseValue.FlattenBottomThreshold : default);
                        var textureSize = CliRuntime.WasSpecified(parseResult, TextureSize) ? parseResult.GetValue(TextureSize) : (__requestBase is { } __TextureSizeBaseValue ? __TextureSizeBaseValue.TextureSize : default);
                        var textureFormat = CliRuntime.WasSpecified(parseResult, TextureFormat) ? parseResult.GetValue(TextureFormat) : (__requestBase is { } __TextureFormatBaseValue ? __TextureFormatBaseValue.TextureFormat : default);
                        var bake = CliRuntime.WasSpecified(parseResult, Bake) ? parseResult.GetValue(Bake) : (__requestBase is { } __BakeBaseValue ? __BakeBaseValue.Bake : default);
                        var packUv = CliRuntime.WasSpecified(parseResult, PackUv) ? parseResult.GetValue(PackUv) : (__requestBase is { } __PackUvBaseValue ? __PackUvBaseValue.PackUv : default);
                        var exportVertexColors = CliRuntime.WasSpecified(parseResult, ExportVertexColors) ? parseResult.GetValue(ExportVertexColors) : (__requestBase is { } __ExportVertexColorsBaseValue ? __ExportVertexColorsBaseValue.ExportVertexColors : default);
                        var pivotToCenterBottom = CliRuntime.WasSpecified(parseResult, PivotToCenterBottom) ? parseResult.GetValue(PivotToCenterBottom) : (__requestBase is { } __PivotToCenterBottomBaseValue ? __PivotToCenterBottomBaseValue.PivotToCenterBottom : default);
                        var scaleFactor = CliRuntime.WasSpecified(parseResult, ScaleFactor) ? parseResult.GetValue(ScaleFactor) : (__requestBase is { } __ScaleFactorBaseValue ? __ScaleFactorBaseValue.ScaleFactor : default);
                        var withAnimation = CliRuntime.WasSpecified(parseResult, WithAnimation) ? parseResult.GetValue(WithAnimation) : (__requestBase is { } __WithAnimationBaseValue ? __WithAnimationBaseValue.WithAnimation : default);
                        var animateInPlace = CliRuntime.WasSpecified(parseResult, AnimateInPlace) ? parseResult.GetValue(AnimateInPlace) : (__requestBase is { } __AnimateInPlaceBaseValue ? __AnimateInPlaceBaseValue.AnimateInPlace : default);
                        var partNames = CliRuntime.WasSpecified(parseResult, PartNames) ? parseResult.GetValue(PartNames) : (__requestBase is { } __PartNamesBaseValue ? __PartNamesBaseValue.PartNames : default);
                        var exportOrientation = CliRuntime.WasSpecified(parseResult, ExportOrientation) ? parseResult.GetValue(ExportOrientation) : (__requestBase is { } __ExportOrientationBaseValue ? __ExportOrientationBaseValue.ExportOrientation : default);
                        var fbxPreset = CliRuntime.WasSpecified(parseResult, FbxPreset) ? parseResult.GetValue(FbxPreset) : (__requestBase is { } __FbxPresetBaseValue ? __FbxPresetBaseValue.FbxPreset : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Models.ConvertModelAsync(
                                    input: input,
                                    format: format,
                                    quad: quad,
                                    forceSymmetry: forceSymmetry,
                                    faceLimit: faceLimit,
                                    flattenBottom: flattenBottom,
                                    flattenBottomThreshold: flattenBottomThreshold,
                                    textureSize: textureSize,
                                    textureFormat: textureFormat,
                                    bake: bake,
                                    packUv: packUv,
                                    exportVertexColors: exportVertexColors,
                                    pivotToCenterBottom: pivotToCenterBottom,
                                    scaleFactor: scaleFactor,
                                    withAnimation: withAnimation,
                                    animateInPlace: animateInPlace,
                                    partNames: partNames,
                                    exportOrientation: exportOrientation,
                                    fbxPreset: fbxPreset,
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