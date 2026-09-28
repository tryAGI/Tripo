#nullable enable

using System.CommandLine;

namespace Tripo.CLI.Commands;

internal static partial class MeshApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"mesh", @"Mesh endpoint commands.");
                         command.Subcommands.Add(MeshCompleteMeshCommandApiCommand.Create());
                         command.Subcommands.Add(MeshDecimateMeshCommandApiCommand.Create());
                         command.Subcommands.Add(MeshSegmentMeshCommandApiCommand.Create());
                         command.Subcommands.Add(MeshSmartSegmentMeshCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}