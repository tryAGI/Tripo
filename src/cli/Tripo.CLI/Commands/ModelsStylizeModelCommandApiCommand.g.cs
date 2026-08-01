#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Tripo.CLI.Commands;

internal static partial class ModelsStylizeModelCommandApiCommand
{
    private static Option<string?> InputOption { get; } = new(
        name: @"--input")
    {
        Description = @"Model source. Accepts task_id or file_token.",
    };

    private static Option<string?> OriginalModelTaskId { get; } = new(
        name: @"--original-model-task-id")
    {
        Description = @"V2-compatible source model task ID.",
    };

    private static Option<string> Style { get; } = new(
        name: @"--style")
    {
        Description = @"Style type, one of lego, voxel, voronoi, minecraft, keyring, fridge_magnet, or keycap.",
        Required = true,
    };

    private static Option<int?> BlockSize { get; } = new(
        name: @"--block-size")
    {
        Description = @"Grid size, range 32-128. Only valid when style is minecraft.",
    };

    private static Option<bool?> Vxc { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--vxc",
        description: @"Enable VXC processing. Requires account entitlement.");

    private static Option<bool?> RenderImage { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--render-image",
        description: @"Generate a rendered preview image.");
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
        var command = new Command(@"stylize-model", @"Stylize an existing model");
                        command.Options.Add(InputOption);
                        command.Options.Add(OriginalModelTaskId);
                        command.Options.Add(Style);
                        command.Options.Add(BlockSize);
                        command.Options.Add(Vxc);
                        command.Options.Add(RenderImage);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Tripo.StylizeModelRequest>(
                            parseResult,
                            RequestInput,
                            RequestJson,
                            RequestFile,
                            global::Tripo.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var input = CliRuntime.WasSpecified(parseResult, InputOption) ? parseResult.GetValue(InputOption) : (__requestBase is { } __InputBaseValue ? __InputBaseValue.Input : default);
                        var originalModelTaskId = CliRuntime.WasSpecified(parseResult, OriginalModelTaskId) ? parseResult.GetValue(OriginalModelTaskId) : (__requestBase is { } __OriginalModelTaskIdBaseValue ? __OriginalModelTaskIdBaseValue.OriginalModelTaskId : default);
                        var style = parseResult.GetRequiredValue(Style);
                        var blockSize = CliRuntime.WasSpecified(parseResult, BlockSize) ? parseResult.GetValue(BlockSize) : (__requestBase is { } __BlockSizeBaseValue ? __BlockSizeBaseValue.BlockSize : default);
                        var vxc = CliRuntime.WasSpecified(parseResult, Vxc) ? parseResult.GetValue(Vxc) : (__requestBase is { } __VxcBaseValue ? __VxcBaseValue.Vxc : default);
                        var renderImage = CliRuntime.WasSpecified(parseResult, RenderImage) ? parseResult.GetValue(RenderImage) : (__requestBase is { } __RenderImageBaseValue ? __RenderImageBaseValue.RenderImage : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Models.StylizeModelAsync(
                                    input: input,
                                    originalModelTaskId: originalModelTaskId,
                                    style: style,
                                    blockSize: blockSize,
                                    vxc: vxc,
                                    renderImage: renderImage,
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