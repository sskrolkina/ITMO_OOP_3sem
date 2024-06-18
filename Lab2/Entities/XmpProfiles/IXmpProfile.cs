using Itmo.ObjectOrientedProgramming.Lab2.Entities.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.XmpProfiles;

public interface IXmpProfile
{
    Timing Timing { get; }
    PowerConsumption Voltage { get; }
    Frequency Frequency { get; }
}