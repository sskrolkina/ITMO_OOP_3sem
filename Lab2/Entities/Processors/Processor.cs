using Itmo.ObjectOrientedProgramming.Lab2.Entities.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Processors;

public class Processor : IProcessor
{
    public Processor(string name, Frequency coreFrequency, Quantity numberOfCores, ProcessorSocket socket, VideoCore videoCore, Frequency memory, ThermalDesignPower thermal, PowerConsumption power)
    {
        CoreFrequency = coreFrequency;
        NumberOfCores = numberOfCores;
        Socket = socket;
        VideoCore = videoCore;
        MemoryFrequency = memory;
        ThermalDesignPower = thermal;
        PowerConsumption = power;
        Name = name;
    }

    public Frequency CoreFrequency { get; }
    public Quantity NumberOfCores { get; }
    public ProcessorSocket Socket { get; set; }
    public VideoCore VideoCore { get; }
    public Frequency MemoryFrequency { get; }
    public ThermalDesignPower ThermalDesignPower { get; }
    public PowerConsumption PowerConsumption { get; }
    public string Name { get; }
}
