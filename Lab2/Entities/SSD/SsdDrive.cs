using Itmo.ObjectOrientedProgramming.Lab2.Entities.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.SSD;

public class SsdDrive : ISsdDrive
{
    public SsdDrive(string name, MemorySize memoryCapacity, ComponentType type, WorkSpeed speed, PowerConsumption power)
    {
        MemoryCapacity = memoryCapacity;
        ConnectionType = type;
        MaximumWorkSpeed = speed;
        PowerConsumption = power;
        Name = name;
    }

    public MemorySize MemoryCapacity { get; }
    public ComponentType ConnectionType { get; }
    public WorkSpeed MaximumWorkSpeed { get; }
    public PowerConsumption PowerConsumption { get; }
    public string Name { get; }
}