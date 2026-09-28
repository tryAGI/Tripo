#nullable enable

using System.CommandLine;

namespace Tripo.CLI.Commands;

internal static partial class AccountApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"account", @"Account endpoint commands.");
                         command.Subcommands.Add(AccountGetBalanceCommandApiCommand.Create());
                         command.Subcommands.Add(AccountGetUsageCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}