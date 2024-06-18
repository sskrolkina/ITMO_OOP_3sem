using Itmo.ObjectOrientedProgramming.Lab2.Entities.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.HardDrives;

public interface IHardDrive : IComponent
{
    MemorySize MemoryCapacity { get; }
    WorkSpeed SpindleRotationSpeed { get; }
    PowerConsumption PowerConsumption { get; }
}