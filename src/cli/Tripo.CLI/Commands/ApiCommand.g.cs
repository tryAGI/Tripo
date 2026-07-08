#nullable enable

using System.CommandLine;

namespace Tripo.CLI.Commands;

internal static class ApiCommand
{
    public static Command Create()
    {
        var command = new Command("api", "Generated endpoint commands.");

                         command.Subcommands.Add(AccountApiGroupCommand.Create());
                         command.Subcommands.Add(AnimationApiGroupCommand.Create());
                         command.Subcommands.Add(FilesApiGroupCommand.Create());
                         command.Subcommands.Add(ImageGenerationApiGroupCommand.Create());
                         command.Subcommands.Add(MeshApiGroupCommand.Create());
                         command.Subcommands.Add(ModelsApiGroupCommand.Create());
                         command.Subcommands.Add(TasksApiGroupCommand.Create());
                         command.Subcommands.Add(ThreeDGenerationApiGroupCommand.Create());
        return command;
    }
}