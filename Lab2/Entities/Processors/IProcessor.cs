using Itmo.ObjectOrientedProgramming.Lab2.Entities.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Processors;

public interface IProcessor : IComponent
{
    Frequency CoreFrequency { get; }
    Quantity NumberOfCores { get; }
    ProcessorSocket Socket { get; set; }
    VideoCore VideoCore { get; }
    Frequency MemoryFrequency { get; }
    ThermalDesignPower ThermalDesignPower { get; }
    PowerConsumption PowerConsumption { get; }
}