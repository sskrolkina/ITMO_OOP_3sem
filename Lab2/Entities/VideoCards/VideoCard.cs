using Itmo.ObjectOrientedProgramming.Lab2.Entities.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.VideoCards;

public class VideoCard : IVideoCard
{
    public VideoCard(string name, Dimension sizeParameter, Frequency chipFrequency, MemorySize videoMemory, PowerConsumption power, ProductVersion version)
    {
        SizeParameter = sizeParameter;
        ChipFrequency = chipFrequency;
        VideoMemory = videoMemory;
        PowerConsumption = power;
        PeripheralComponentInterconnectExpress = version;
        Name = name;
    }

    public Dimension SizeParameter { get; }
    public Frequency ChipFrequency { get; }
    public MemorySize VideoMemory { get; }
    public PowerConsumption PowerConsumption { get; }
    public ProductVersion PeripheralComponentInterconnectExpress { get; }
    public string Name { get; }
}