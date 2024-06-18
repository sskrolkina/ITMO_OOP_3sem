using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Cooler;

public class ProcessorCoolingSystem : IProcessorCoolingSystem
{
    public ProcessorCoolingSystem(string name, Dimension size, IEnumerable<ProcessorSocket> sockets, ThermalDesignPower max)
    {
        CoolerSize = size;
        SupportedSockets = sockets.ToArray();
        MaximumThermalDesignPower = max;
        Name = name;
    }

    public Dimension CoolerSize { get; }
    public ThermalDesignPower MaximumThermalDesignPower { get; }
    public IReadOnlyCollection<ProcessorSocket> SupportedSockets { get; }

    public string Name { get; }
}