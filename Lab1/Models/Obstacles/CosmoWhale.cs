using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environment;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

public class CosmoWhale : NitrideParticlesNebula, IObstacles
{
    private const int CosmoWhaleDamage = 400;
    public int Damage => CosmoWhaleDamage;
}