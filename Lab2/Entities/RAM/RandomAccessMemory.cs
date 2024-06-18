using Itmo.ObjectOrientedProgramming.Lab2.Entities.Components;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.XmpProfiles;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.RAM;

public class RandomAccessMemory : IRandomAccessMemory
{
    public RandomAccessMemory(string name, MemorySize maxSize, FormFactor form, ProductVersion ddr, PowerConsumption power, IXmpProfile xmp, Frequency frequency)
    {
        AmountOfAvailableMemorySize = maxSize;
        FormFactor = form;
        DoubleDataRate = ddr;
        PowerConsumption = power;
        Name = name;
        XmpProfile = xmp;
        Frequency = frequency;
    }

    public MemorySize AmountOfAvailableMemorySize { get; }
    public FormFactor FormFactor { get; }
    public ProductVersion DoubleDataRate { get; }
    public PowerConsumption PowerConsumption { get; }
    public IXmpProfile XmpProfile { get; }
    public Frequency Frequency { get; }
    public string Name { get; }
}