using Itmo.ObjectOrientedProgramming.Lab2.Entities.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.PowerSupplies;

public class PowerSupply : IPowerSupply
{
    public PowerSupply(string name, PowerConsumption power)
    {
        MaximumPowerConsumption = power;
        Name = name;
    }

    public PowerConsumption MaximumPowerConsumption { get; }
    public string Name { get; }
}