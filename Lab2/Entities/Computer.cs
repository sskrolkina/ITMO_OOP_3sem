using Itmo.ObjectOrientedProgramming.Lab2.Entities.BIOS;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.ComputerCases;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Cooler;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.HardDrives;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Motherboards;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.PowerSupplies;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Processors;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.RAM;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.SSD;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.VideoCards;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.WiFi;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities;

public class Computer
{
    public Computer(
        IBasicInputOutputSystem? bios,
        IComputerCase? computerCase,
        IProcessorCoolingSystem? cooler,
        IHardDrive? drive,
        IMotherboard? motherboard,
        IPowerSupply? powerSupply,
        IProcessor? processor,
        IRandomAccessMemory? ram,
        ISsdDrive? ssd,
        IVideoCard? videoCard,
        IWiFi? wiFi)
    {
        Processor = processor;
        ProcessorCoolingSystem = cooler;
        Motherboard = motherboard;
        ComputerCase = computerCase;
        BasicInputOutputSystem = bios;
        HardDrive = drive;
        PowerSupply = powerSupply;
        RandomAccessMemory = ram;
        SsdDrive = ssd;
        VideoCard = videoCard;
        WiFi = wiFi;
    }

    public IBasicInputOutputSystem? BasicInputOutputSystem { get; }

    public IComputerCase? ComputerCase { get; }

    public IProcessorCoolingSystem? ProcessorCoolingSystem { get; }

    public IHardDrive? HardDrive { get; }

    public IMotherboard? Motherboard { get; }

    public IPowerSupply? PowerSupply { get; }

    public IProcessor? Processor { get; }

    public IRandomAccessMemory? RandomAccessMemory { get; }

    public ISsdDrive? SsdDrive { get; }

    public IVideoCard? VideoCard { get; }
    public IWiFi? WiFi { get; }
}