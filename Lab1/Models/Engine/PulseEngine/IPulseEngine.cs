namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Engine.PulseEngine;

public interface IPulseEngine : IEngine
{
    Fuel AmountOfFuel { get; }
    void SpentFuel();
}