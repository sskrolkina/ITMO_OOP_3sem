namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Deflectors;

public interface IDeflector
{
    int Strength { get; set; }
    Damage DeflectObstacle(Damage damage);
}