using Itmo.ObjectOrientedProgramming.Lab4.Results;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands;

public class DeleteCommand : ICommand
{
    private IFileSystemCommandsReceiver _receiver;
    private string _path;

    public DeleteCommand(string path, IFileSystemCommandsReceiver receiver)
    {
        _path = path;
        _receiver = receiver;
    }

    public Result Execute()
    {
        return _receiver.Delete(_path);
    }
}