#nullable enable

using System.CommandLine;

namespace Tripo.CLI.Commands;

internal static class AnimationApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"animation", @"Animation endpoint commands.");
                         command.Subcommands.Add(AnimationRetargetAnimationCommandApiCommand.Create());
                         command.Subcommands.Add(AnimationRigCheckCommandApiCommand.Create());
                         command.Subcommands.Add(AnimationRigModelCommandApiCommand.Create());
        return command;
    }
}