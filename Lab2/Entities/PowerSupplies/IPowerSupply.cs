using Itmo.ObjectOrientedProgramming.Lab2.Entities.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.PowerSupplies;

public interface IPowerSupply : IComponent
{
    PowerConsumption MaximumPowerConsumption { get; }
}