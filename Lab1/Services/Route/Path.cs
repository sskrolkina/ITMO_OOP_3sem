using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environment;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ship;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services.Route;

public class Path : IRoute
{
    private readonly double _distance;

    public Path(IReadOnlyCollection<IRoute> path)
    {
        ArgumentNullException.ThrowIfNull(path);
        foreach (IRoute route in path)
        {
            switch (route)
            {
                case ShortDistanceRoute:
                    _distance += route.Distance;
                    break;
                case MiddleDistanceRoute:
                    _distance += route.Distance;
                    break;
                case LongDistanceRoute:
                    _distance += route.Distance;
                    break;
            }
        }
    }

    public double Distance => _distance;

    public bool TryToFly(SpaceShip ship, IEnvironment environment)
    {
        ArgumentNullException.ThrowIfNull(ship);
        ArgumentNullException.ThrowIfNull(environment);
        return environment.Fly(ship) >= _distance;
    }
}