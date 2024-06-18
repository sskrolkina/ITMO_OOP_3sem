using Itmo.ObjectOrientedProgramming.Lab2.Entities.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.WiFi;

public interface IWiFi : IComponent
{
    ProductVersion WiFitVersion { get; }
    Bluetooth Bluetooth { get; }
    ProductVersion PciE { get; }
    PowerConsumption PowerConsumption { get; }
}