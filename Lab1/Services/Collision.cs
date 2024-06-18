using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environment;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ship;
using Itmo.ObjectOrientedProgramming.Lab1.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services;

public class Collision : ICollisions
{
    private readonly IReadOnlyCollection<IObstacles> _obstacles;
    private readonly SpaceShip _ship;
    private Damage _allDamage;
    public Collision(IReadOnlyCollection<IObstacles> obstacles, SpaceShip ship)
    {
        _obstacles = obstacles;
        _ship = ship;
        _allDamage = new Damage(0);
    }

    public void TryToCollide(IEnvironment environment)
    {
        foreach (IObstacles obstacle in _obstacles)
        {
            switch (obstacle)
            {
                case Space when environment is Space:
                case HighDensityNebula when environment is HighDensityNebula:
                case NitrideParticlesNebula when environment is NitrideParticlesNebula:
                    _allDamage = _allDamage with { ExtraDamage = _allDamage.ExtraDamage + obstacle.Damage };
                    break;
            }
        }

        _ship.DeflectObstacle(_allDamage);
    }
}