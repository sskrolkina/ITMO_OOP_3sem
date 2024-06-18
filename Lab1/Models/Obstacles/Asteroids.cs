using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environment;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

public class Asteroids : Space, IObstacles
{
    private const int AsteroidDamage = 10;
    public int Damage => AsteroidDamage;
}