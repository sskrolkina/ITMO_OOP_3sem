using Itmo.ObjectOrientedProgramming.Lab4.Results;

namespace Itmo.ObjectOrientedProgramming.Lab4.Commands;

public interface IFileSystemCommandsReceiver
{
    Result Copy();
    Result Delete(string path);
}