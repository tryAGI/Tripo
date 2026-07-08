#nullable enable

using System.CommandLine;

namespace Tripo.CLI.Commands;

internal static class FilesApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"files", @"Files endpoint commands.");
                         command.Subcommands.Add(FilesGetUploadCredentialsCommandApiCommand.Create());
                         command.Subcommands.Add(FilesPresignFileUploadCommandApiCommand.Create());
                         command.Subcommands.Add(FilesUploadFileCommandApiCommand.Create());
        return command;
    }
}