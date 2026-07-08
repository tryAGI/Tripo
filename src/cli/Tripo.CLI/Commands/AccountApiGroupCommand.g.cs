#nullable enable

using System.CommandLine;

namespace Tripo.CLI.Commands;

internal static class AccountApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"account", @"Account endpoint commands.");
                         command.Subcommands.Add(AccountGetBalanceCommandApiCommand.Create());
                         command.Subcommands.Add(AccountGetUsageCommandApiCommand.Create());
        return command;
    }
}