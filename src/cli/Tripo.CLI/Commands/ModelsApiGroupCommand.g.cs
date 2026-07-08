#nullable enable

using System.CommandLine;

namespace Tripo.CLI.Commands;

internal static class ModelsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"models", @"Models endpoint commands.");
                         command.Subcommands.Add(ModelsConvertModelCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsImportModelCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsRefineModelCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsStylizeModelCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsTextureModelCommandApiCommand.Create());
        return command;
    }
}