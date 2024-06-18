using Itmo.ObjectOrientedProgramming.Lab2.Entities.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.VideoCards;

public interface IVideoCard : IComponent
{
    Dimension SizeParameter { get; }
    Frequency ChipFrequency { get; }
    MemorySize VideoMemory { get; }
    ProductVersion PeripheralComponentInterconnectExpress { get; }
    PowerConsumption PowerConsumption { get; }
}