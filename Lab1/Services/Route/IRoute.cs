using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environment;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ship;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services.Route;

public interface IRoute
{
    double Distance { get; }
    bool TryToFly(SpaceShip ship, IEnvironment environment);
}