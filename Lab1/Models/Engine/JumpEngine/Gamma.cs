using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Engine.JumpEngine;

public class Gamma : IJumpEngine
{
    private const int AverageSpeed = 250;
    private const int AverageAmountOfFuel = 100;
    public Fuel AmountOfFuel { get; } = new Fuel();
    public double Boost => AverageSpeed * Math.Log(AverageSpeed);
    public void SpentFuel()
    {
        AmountOfFuel.FuelQuantity = AverageAmountOfFuel * Boost;
    }
}