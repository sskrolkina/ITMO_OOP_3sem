using Itmo.ObjectOrientedProgramming.Lab2.Entities.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.XmpProfiles;

public class XmpProfile : IXmpProfile
{
    public XmpProfile(Timing timing, PowerConsumption voltage, Frequency frequency)
    {
        Timing = timing;
        Voltage = voltage;
        Frequency = frequency;
    }

    public Timing Timing { get; }
    public PowerConsumption Voltage { get; }
    public Frequency Frequency { get; }
}