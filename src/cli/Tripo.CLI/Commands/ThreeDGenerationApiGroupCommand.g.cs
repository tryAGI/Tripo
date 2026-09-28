#nullable enable

using System.CommandLine;

namespace Tripo.CLI.Commands;

internal static partial class ThreeDGenerationApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"three-dgeneration", @"ThreeDGeneration endpoint commands.");
                         command.Subcommands.Add(ThreeDGenerationImageToModelCommandApiCommand.Create());
                         command.Subcommands.Add(ThreeDGenerationImageToSplatCommandApiCommand.Create());
                         command.Subcommands.Add(ThreeDGenerationMultiviewToModelCommandApiCommand.Create());
                         command.Subcommands.Add(ThreeDGenerationTextToModelCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}