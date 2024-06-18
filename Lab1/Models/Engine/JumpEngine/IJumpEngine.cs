namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Engine.JumpEngine;

public interface IJumpEngine : IEngine
{
    Fuel AmountOfFuel { get; }
    void SpentFuel();
}