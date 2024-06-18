using Itmo.ObjectOrientedProgramming.Lab2.Entities.BIOS;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.ComputerCases;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Cooler;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.HardDrives;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Motherboards;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.PowerSupplies;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Processors;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.RAM;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Repositories;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.SSD;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.VideoCards;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.WiFi;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities;

public class ComputerBuilder
{
    private CreatingRepositories _repo;
    private IBasicInputOutputSystem? _basicInputOutputSystem;
    private IComputerCase? _computerCase;
    private IProcessorCoolingSystem? _coolingSystem;
    private IHardDrive? _hardDrive;
    private IMotherboard? _motherboard;
    private IPowerSupply? _powerSupply;
    private IProcessor? _processor;
    private IRandomAccessMemory? _randomAccessMemory;
    private ISsdDrive? _ssdDrive;
    private IVideoCard? _videoCard;
    private IWiFi? _wiFi;

    public ComputerBuilder()
    {
        _repo = CreatingRepositories.GetInstance;
    }

    public bool AddCase(string? name)
    {
        if (_repo.ComputerCase.FindByName(name) is null) return false;
        _computerCase = _repo.ComputerCase.FindByName(name);
        return true;
    }

    public bool AddBios(string? name)
    {
        if (_repo.Bios.FindByName(name) is null) return false;
        _basicInputOutputSystem = _repo.Bios.FindByName(name);
        return true;
    }

    public bool AddCooler(string? name)
    {
        if (_repo.Cooler.FindByName(name) is null) return false;
        _coolingSystem = _repo.Cooler.FindByName(name);
        return true;
    }

    public bool AddHardDrive(string? name)
    {
        if (_repo.HardDrive.FindByName(name) is null) return false;
        _hardDrive = _repo.HardDrive.FindByName(name);
        return true;
    }

    public bool AddMotherBoard(string? name)
    {
        if (_repo.MotherBoard.FindByName(name) is null) return false;
        _motherboard = _repo.MotherBoard.FindByName(name);
        return true;
    }

    public bool AddPowerSupply(string? name)
    {
        if (_repo.PowerSupply.FindByName(name) is null) return false;
        _powerSupply = _repo.PowerSupply.FindByName(name);
        return true;
    }

    public bool AddProcessor(string? name)
    {
        if (_repo.Processor.FindByName(name) is null) return false;
        _processor = _repo.Processor.FindByName(name);
        return true;
    }

    public bool AddRam(string? name)
    {
        if (_repo.Ram.FindByName(name) is null) return false;
        _randomAccessMemory = _repo.Ram.FindByName(name);
        return true;
    }

    public bool AddSsd(string? name)
    {
        if (_repo.Ssd.FindByName(name) is null) return false;
        _ssdDrive = _repo.Ssd.FindByName(name);
        return true;
    }

    public bool AddVideoCard(string? name)
    {
        if (_repo.VideoCard.FindByName(name) is null) return false;
        _videoCard = _repo.VideoCard.FindByName(name);
        return true;
    }

    public bool AddWifi(string? name)
    {
        if (_repo.WiFi.FindByName(name) is null) return false;
        _wiFi = _repo.WiFi.FindByName(name);
        return true;
    }

    public void AddComputer(Computer computer)
    {
        _basicInputOutputSystem = computer?.BasicInputOutputSystem;
        _computerCase = computer?.ComputerCase;
        _coolingSystem = computer?.ProcessorCoolingSystem;
        _hardDrive = computer?.HardDrive;
        _motherboard = computer?.Motherboard;
        _powerSupply = computer?.PowerSupply;
        _processor = computer?.Processor;
        _randomAccessMemory = computer?.RandomAccessMemory;
        _ssdDrive = computer?.SsdDrive;
        _videoCard = computer?.VideoCard;
    }

    public Computer Build()
    {
        return new Computer(
            _basicInputOutputSystem,
            _computerCase,
            _coolingSystem,
            _hardDrive,
            _motherboard,
            _powerSupply,
            _processor,
            _randomAccessMemory,
            _ssdDrive,
            _videoCard,
            _wiFi);
    }
}