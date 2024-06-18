using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environment;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

public class AntimatterFlares : HighDensityNebula, IObstacles
{
    private const int AntiMatterFlareDamage = 1000;
    public int Damage => AntiMatterFlareDamage;
}