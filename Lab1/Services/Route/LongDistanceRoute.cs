using System;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environment;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ship;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services.Route;

public class LongDistanceRoute : IRoute
{
    private const double LongDistance = 1000;

    public double Distance => LongDistance;

    public bool TryToFly(SpaceShip ship, IEnvironment environment)
    {
        ArgumentNullException.ThrowIfNull(ship);
        ArgumentNullException.ThrowIfNull(environment);
        return environment.Fly(ship) >= LongDistance;
    }
}
