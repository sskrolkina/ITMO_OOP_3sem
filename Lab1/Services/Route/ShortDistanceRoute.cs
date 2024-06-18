using System;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environment;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ship;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services.Route;

public class ShortDistanceRoute : IRoute
{
    private const int ShortDistance = 200;
    public double Distance => ShortDistance;

    public bool TryToFly(SpaceShip ship, IEnvironment environment)
    {
        ArgumentNullException.ThrowIfNull(ship);
        ArgumentNullException.ThrowIfNull(environment);
        return environment.Fly(ship) >= ShortDistance;
    }
}