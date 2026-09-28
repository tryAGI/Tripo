#nullable enable

using System.CommandLine;

namespace Tripo.CLI.Commands;

internal static partial class ModelsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"models", @"Models endpoint commands.");
                         command.Subcommands.Add(ModelsConvertModelCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsImportModelCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsRefineModelCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsStylizeModelCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsTextureModelCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}