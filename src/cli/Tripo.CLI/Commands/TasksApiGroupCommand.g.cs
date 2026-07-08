#nullable enable

using System.CommandLine;

namespace Tripo.CLI.Commands;

internal static class TasksApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"tasks", @"Tasks endpoint commands.");
                         command.Subcommands.Add(TasksGetTaskCommandApiCommand.Create());
                         command.Subcommands.Add(TasksListTasksCommandApiCommand.Create());
        return command;
    }
}