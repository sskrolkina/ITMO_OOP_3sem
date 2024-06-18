using Itmo.ObjectOrientedProgramming.Lab2.Entities.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.HardDrives;

public class HardDrive : IHardDrive
{
    public HardDrive(string name, MemorySize capacity, WorkSpeed speed, PowerConsumption power)
    {
        MemoryCapacity = capacity;
        SpindleRotationSpeed = speed;
        PowerConsumption = power;
        Name = name;
    }

    public MemorySize MemoryCapacity { get; }
    public WorkSpeed SpindleRotationSpeed { get; }
    public PowerConsumption PowerConsumption { get; }
    public string Name { get; }
}