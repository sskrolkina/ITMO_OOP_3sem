namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Engine.PulseEngine;

public class CPulseEngine : IPulseEngine
{
    private const double AverageSpeed = 200;
    private const double AverageAmountOfFuel = 100;
    public Fuel AmountOfFuel { get; } = new Fuel();

    public double Boost => AverageSpeed;
    public void SpentFuel()
    {
        AmountOfFuel.FuelQuantity = AverageAmountOfFuel * Boost;
    }
}