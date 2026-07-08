#nullable enable

using System.CommandLine;

namespace Tripo.CLI.Commands;

internal static class ImageGenerationApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"image-generation", @"Image Generation endpoint commands.");
                         command.Subcommands.Add(ImageGenerationEditMultiviewCommandApiCommand.Create());
                         command.Subcommands.Add(ImageGenerationImageToImageCommandApiCommand.Create());
                         command.Subcommands.Add(ImageGenerationImageToMultiviewCommandApiCommand.Create());
                         command.Subcommands.Add(ImageGenerationTextToImageCommandApiCommand.Create());
        return command;
    }
}