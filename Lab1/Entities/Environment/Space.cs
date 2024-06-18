using System;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ship;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Environment;

public class Space : IEnvironment
{
    public bool TryToFly(SpaceShip ship)
    {
        ArgumentNullException.ThrowIfNull(ship);
        return ship.PulseEngine is not null;
    }

    public double Fly(SpaceShip ship)
    {
        ArgumentNullException.ThrowIfNull(ship);
        return ship.PulseBoost();
    }
}