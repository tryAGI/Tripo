#nullable enable

using System.CommandLine;

namespace Tripo.CLI.Commands;

internal static class DefaultApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"default", @"default endpoint commands.");
                         command.Subcommands.Add(CreateTaskCommandApiCommand.Create());
                         command.Subcommands.Add(GetBalanceCommandApiCommand.Create());
                         command.Subcommands.Add(GetTaskCommandApiCommand.Create());
                         command.Subcommands.Add(UploadFileCommandApiCommand.Create());
        return command;
    }
}