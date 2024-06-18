using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Cooler;

public interface IProcessorCoolingSystem : IComponent
{
    Dimension CoolerSize { get; }
    ThermalDesignPower MaximumThermalDesignPower { get; }
    IReadOnlyCollection<ProcessorSocket> SupportedSockets { get; }
}