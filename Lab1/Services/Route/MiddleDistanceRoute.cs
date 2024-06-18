using System;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environment;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ship;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services.Route;

public class MiddleDistanceRoute : IRoute
{
    private const double MiddleDistance = 400;

    public double Distance => MiddleDistance;

    public bool TryToFly(SpaceShip ship, IEnvironment environment)
    {
        ArgumentNullException.ThrowIfNull(ship);
        ArgumentNullException.ThrowIfNull(environment);
        return environment.Fly(ship) >= MiddleDistance;
    }
}