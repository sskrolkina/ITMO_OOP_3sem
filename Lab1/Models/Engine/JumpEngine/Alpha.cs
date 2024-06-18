namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Engine.JumpEngine;

public class Alpha : IJumpEngine
{
    private const double AverageSpeed = 250;
    private const double AverageAmountOfFuel = 100;

    public Fuel AmountOfFuel { get; } = new Fuel();
    public double Boost => AverageSpeed;
    public void SpentFuel()
    {
        AmountOfFuel.FuelQuantity = AverageAmountOfFuel * Boost;
    }
}