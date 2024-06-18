using Itmo.ObjectOrientedProgramming.Lab2.Entities.Components;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.XmpProfiles;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.RAM;

public interface IRandomAccessMemory : IComponent
{
    MemorySize AmountOfAvailableMemorySize { get; }
    ProductVersion DoubleDataRate { get; }
    PowerConsumption PowerConsumption { get; }
    IXmpProfile? XmpProfile { get; }
    Frequency Frequency { get; }
}