using System;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Components;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.WiFi;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.XmpProfiles;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Motherboards;

public class Motherboard : IMotherboard
{
    public Motherboard(string name, FormFactor size, ProductVersion pci, ProductVersion sata, Quantity rama, ProcessorSocket socket, ProductVersion version, ComponentType biosType, ProductVersion biosVersion, IXmpProfile xmpProfile, WifiAdapter wifiAdapter)
    {
        ArgumentNullException.ThrowIfNull(size);
        FormFactor = size;
        PeripheralComponentInterconnectExpress = pci;
        SerialAdvancedTechnologyAttachment = sata;
        RandomAccessMemorySlots = rama;
        ProcessorSocket = socket;
        DoubleDataRate = version;
        BiosVersion = biosVersion;
        BiosType = biosType;
        Name = name;
        XmpProfile = xmpProfile;
        WiFi = wifiAdapter;
    }

    public FormFactor FormFactor { get; }
    public ProductVersion PeripheralComponentInterconnectExpress { get; }
    public ProductVersion SerialAdvancedTechnologyAttachment { get; }
    public Quantity RandomAccessMemorySlots { get; }
    public ProcessorSocket ProcessorSocket { get; }
    public ProductVersion DoubleDataRate { get; }
    public ComponentType BiosType { get; }
    public ProductVersion BiosVersion { get; }
    public IXmpProfile? XmpProfile { get; }
    public IWiFi? WiFi { get; }
    public string Name { get; }
}
