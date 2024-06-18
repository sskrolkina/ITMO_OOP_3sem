using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Engine.PulseEngine;

public class EPulseEngine : IPulseEngine
{
    private const double AverageSpeed = 200;
    private const double AverageAmountOfFuel = 100;
    public Fuel AmountOfFuel { get; } = new Fuel();

    public double Boost => AverageSpeed * Math.Exp(AverageSpeed);

    public void SpentFuel()
    {
        AmountOfFuel.FuelQuantity = AverageAmountOfFuel * Boost;
    }
}