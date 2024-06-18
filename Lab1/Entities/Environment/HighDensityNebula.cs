using System;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ship;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Environment;

public class HighDensityNebula : IEnvironment
{
    public bool TryToFly(SpaceShip ship)
    {
        ArgumentNullException.ThrowIfNull(ship);
        return ship.JumpEngine is not null;
    }

    public double Fly(SpaceShip ship)
    {
        ArgumentNullException.ThrowIfNull(ship);
        return ship.JumpBoost();
    }
}