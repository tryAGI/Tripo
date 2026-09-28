#nullable enable

using System.CommandLine;

namespace Tripo.CLI.Commands;

internal static partial class TasksApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"tasks", @"Tasks endpoint commands.");
                         command.Subcommands.Add(TasksGetTaskCommandApiCommand.Create());
                         command.Subcommands.Add(TasksListTasksCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}