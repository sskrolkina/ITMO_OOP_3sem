using Itmo.ObjectOrientedProgramming.Lab4.Results;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands;

public class NullCommand : ICommand
{
    public Result Execute()
    {
        throw new System.NotImplementedException();
    }
}