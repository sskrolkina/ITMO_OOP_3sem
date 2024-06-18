using System;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environment;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ship;
using Itmo.ObjectOrientedProgramming.Lab1.Services.Route;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services.Outcomes;

public class Travel
{
    private Travel? _result;

    public Travel TryToFly(SpaceShip ship, IEnvironment environment)
    {
        ArgumentNullException.ThrowIfNull(environment);
        if (!environment.TryToFly(ship))
        {
            _result = new ShipCanNotGoThere();
        }
        else
        {
            _result = new ShipInEnvironment();
        }

        return _result;
    }

    public Travel Fly(IRoute route, SpaceShip ship, IEnvironment environment)
    {
        ArgumentNullException.ThrowIfNull(route);
        if (!route.TryToFly(ship, environment))
        {
            _result = new ShipCompletedTheRoute();
        }
        else
        {
            _result = new ShipDidNotReach();
        }

        return _result;
    }
}