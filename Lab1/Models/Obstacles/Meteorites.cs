using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environment;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

public class Meteorites : Space, IObstacles
{
    private const int MeteoriteDamage = 25;
    public int Damage => MeteoriteDamage;
}