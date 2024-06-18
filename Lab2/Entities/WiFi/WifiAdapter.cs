using Itmo.ObjectOrientedProgramming.Lab2.Entities.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.WiFi;

public class WifiAdapter : IWiFi
{
    public WifiAdapter(string name, ProductVersion wiFitversion, Bluetooth bluetooth, ProductVersion pcie, PowerConsumption powerConsumption)
    {
        Name = name;
        WiFitVersion = wiFitversion;
        Bluetooth = bluetooth;
        PciE = pcie;
        PowerConsumption = powerConsumption;
    }

    public string Name { get; }
    public ProductVersion WiFitVersion { get; }
    public Bluetooth Bluetooth { get; }
    public ProductVersion PciE { get; }
    public PowerConsumption PowerConsumption { get; }
}
