using Itmo.ObjectOrientedProgramming.Lab2.Entities.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.SSD;

public interface ISsdDrive : IComponent
{
    MemorySize MemoryCapacity { get; }
    ComponentType ConnectionType { get; }
    WorkSpeed MaximumWorkSpeed { get; }
    PowerConsumption PowerConsumption { get; }
}