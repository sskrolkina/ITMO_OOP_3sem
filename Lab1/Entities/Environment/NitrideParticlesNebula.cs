using System;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ship;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Engine.PulseEngine;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Environment;

public class NitrideParticlesNebula : IEnvironment
{
    public bool TryToFly(SpaceShip ship)
    {
        ArgumentNullException.ThrowIfNull(ship);
        return ship.PulseEngine is EPulseEngine;
    }

    public double Fly(SpaceShip ship)
    {
        ArgumentNullException.ThrowIfNull(ship);
        return ship.PulseBoost();
    }
}