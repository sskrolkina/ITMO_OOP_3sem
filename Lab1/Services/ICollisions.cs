using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environment;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services;

public interface ICollisions
{
    void TryToCollide(IEnvironment environment);
}