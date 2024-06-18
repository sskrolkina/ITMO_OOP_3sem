using Itmo.ObjectOrientedProgramming.Lab2.Entities.Components;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.WiFi;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.XmpProfiles;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Motherboards;

public interface IMotherboard : IComponent
{
    ProcessorSocket ProcessorSocket { get; }
    FormFactor FormFactor { get; }
    ProductVersion PeripheralComponentInterconnectExpress { get; }
    ProductVersion SerialAdvancedTechnologyAttachment { get; }
    Quantity RandomAccessMemorySlots { get; }
    ProductVersion DoubleDataRate { get; }
    ComponentType BiosType { get; }
    ProductVersion BiosVersion { get; }
    IXmpProfile? XmpProfile { get; }
    IWiFi? WiFi { get; }
}