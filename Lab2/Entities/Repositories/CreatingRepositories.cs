using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.BIOS;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Components;
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
using Itmo.ObjectOrientedProgramming.Lab2.Entities.XmpProfiles;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Repositories;

public class CreatingRepositories
{
    private static Lazy<CreatingRepositories>? _instance;
    private readonly ComputerCaseRepository _caseRepository;
    private readonly CoolerRepository _cooler;
    private readonly BiosRepository _biosRepository;
    private readonly ProcessorRepository _processorRepository;
    private readonly HardDriveRepository _hardDrivesRepository;
    private readonly MotherBoardRepository _motherboardRepository;
    private readonly PowerSupplyRepository _powerSuppliesRepository;
    private readonly RandomAccessMemoryRepository _ramsRepository;
    private readonly SsdRepository _ssdsRepository;
    private readonly VideoCardRepository _videocardsRepository;
    private readonly WiFiRepository _wiFiRepository;

    private CreatingRepositories()
    {
        _biosRepository = new BiosRepository();
        _caseRepository = new ComputerCaseRepository();
        _processorRepository = new ProcessorRepository();
        _hardDrivesRepository = new HardDriveRepository();
        _motherboardRepository = new MotherBoardRepository();
        _powerSuppliesRepository = new PowerSupplyRepository();
        _cooler = new CoolerRepository();
        _ramsRepository = new RandomAccessMemoryRepository();
        _ssdsRepository = new SsdRepository();
        _videocardsRepository = new VideoCardRepository();
        _wiFiRepository = new WiFiRepository();
        _caseRepository.Add(new ComputerCase("HyperXXX", new Dimension(500, 200), new Dimension(1000, 700), new List<FormFactor>() { new FormFactor("ATX") }));
        _biosRepository.Add(new BasicInputOutputSystem(
            "BIOS",
            new ComponentType("bios"),
            new ProductVersion("bios"),
            new List<string>() { "Intel Core i7-13700KF" }));
        _cooler.Add(new ProcessorCoolingSystem(
            "ID-Cooling SE-224",
            new Dimension(100, 100),
            new List<ProcessorSocket>() { new ProcessorSocket("LGA-1700") },
            new ThermalDesignPower(1900)));
        _cooler.Add(new ProcessorCoolingSystem(
            "DEEPCOOL AG400",
            new Dimension(100, 100),
            new List<ProcessorSocket>() { new ProcessorSocket("LGA-1700") },
            new ThermalDesignPower(1000)));
        _caseRepository.Add(new ComputerCase("HyperXXX", new Dimension(500, 200), new Dimension(1000, 700), new List<FormFactor>() { new FormFactor("ATX") }));
        _hardDrivesRepository.Add(new HardDrive(
            "Seagate BarraCuda",
            new MemorySize(123),
            new WorkSpeed(3033),
            new PowerConsumption(200)));
        _motherboardRepository.Add(
            new Motherboard(
                "GIGABYTE B550",
                new FormFactor("ATX"),
                new ProductVersion("4.0"),
                new ProductVersion("2"),
                new Quantity(2),
                new ProcessorSocket("LGA-1700"),
                new ProductVersion("ddr5"),
                new ComponentType("bios"),
                new ProductVersion("13"),
                new XmpProfile(new Timing("18-18-36-54"), new PowerConsumption(100), new Frequency(45)),
                new WifiAdapter("SUPERROUTER", new ProductVersion("132e"), new Bluetooth(true), new ProductVersion("4.0"), new PowerConsumption(100))));
        _powerSuppliesRepository.Add(new PowerSupply("DEEPCOOL PF-600", new PowerConsumption(5000)));
        _powerSuppliesRepository.Add(new PowerSupply("Cougar STX 700W", new PowerConsumption(2500)));
        _processorRepository.Add(new Processor(
            "IIntel Core i5-11400F",
            new Frequency(2.5),
            new Quantity(10),
            new ProcessorSocket("LGA1200"),
            new VideoCore(true),
            new Frequency(666),
            new ThermalDesignPower(148),
            new PowerConsumption(65)));
        _processorRepository.Add(new Processor(
            "Intel Core i7-13700KF",
            new Frequency(2.5),
            new Quantity(8),
            new ProcessorSocket("LGA-1700"),
            new VideoCore(true),
            new Frequency(2344),
            new ThermalDesignPower(200),
            new PowerConsumption(300)));
        _ramsRepository.Add(new RandomAccessMemory(
            "Patriot Viper 3",
            new MemorySize(1340),
            new FormFactor("smoll"),
            new ProductVersion("ddr5"),
            new PowerConsumption(400),
            new XmpProfile(new Timing("18-18-36-54"), new PowerConsumption(100), new Frequency(45)),
            new Frequency(45)));
        _ssdsRepository.Add(new SsdDrive("Kingston A400", new MemorySize(Size: 8), new ComponentType("4.0"), new WorkSpeed(Speed: 1000), new PowerConsumption(Power: 100)));
        _videocardsRepository.Add(new VideoCard(
            "GeForce GTX 2280",
            new Dimension(300, 200),
            new Frequency(123),
            new MemorySize(12),
            new PowerConsumption(300),
            new ProductVersion("4.0")));
        _wiFiRepository.Add(
            new WifiAdapter(
                "Mercusys MU6H",
                new ProductVersion("123"),
                new Bluetooth(false),
                new ProductVersion("4.0"),
                new PowerConsumption(50)));
    }

    public static CreatingRepositories GetInstance
    {
        get
        {
            if (_instance is null)
                _instance = new Lazy<CreatingRepositories>(() => new CreatingRepositories());
            return _instance.Value;
        }
    }

    public IRepository<ComputerCase> ComputerCase => _caseRepository;
    public IRepository<BasicInputOutputSystem> Bios => _biosRepository;
    public IRepository<Processor> Processor => _processorRepository;
    public IRepository<RandomAccessMemory> Ram => _ramsRepository;
    public IRepository<SsdDrive> Ssd => _ssdsRepository;
    public IRepository<WifiAdapter> WiFi => _wiFiRepository;
    public IRepository<ProcessorCoolingSystem> Cooler => _cooler;
    public IRepository<PowerSupply> PowerSupply => _powerSuppliesRepository;
    public IRepository<Motherboard> MotherBoard => _motherboardRepository;
    public IRepository<HardDrive> HardDrive => _hardDrivesRepository;
    public IRepository<VideoCard> VideoCard => _videocardsRepository;
}