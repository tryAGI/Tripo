#nullable enable

using System.CommandLine;

namespace Tripo.CLI.Commands;

internal static partial class FilesApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"files", @"Files endpoint commands.");
                         command.Subcommands.Add(FilesGetUploadCredentialsCommandApiCommand.Create());
                         command.Subcommands.Add(FilesPresignFileUploadCommandApiCommand.Create());
                         command.Subcommands.Add(FilesUploadFileCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}