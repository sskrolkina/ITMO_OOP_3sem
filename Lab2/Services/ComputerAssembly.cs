using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.Results;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services;

public class ComputerAssembly
{
    private readonly ComputerBuilder _builder;
    private readonly string? _computerCase;
    private readonly string? _powerSupply;
    private readonly string? _motherBoard;
    private readonly string? _ssd;
    private readonly string? _processor;
    private readonly string? _cooler;
    private readonly string? _ram;
    private readonly string? _hardDrive;
    private readonly string? _videoCard;
    private readonly string? _bios;
    private readonly string? _wifi;

    public ComputerAssembly(
        string? computerCase,
        string? powerSupply,
        string? motherBoard,
        string? ssd,
        string? processor,
        string? cooler,
        string? ram,
        string? hardDrive,
        string? videoCard,
        string? bios,
        string? wifi)
    {
        _computerCase = computerCase;
        _powerSupply = powerSupply;
        _motherBoard = motherBoard;
        _ssd = ssd;
        _processor = processor;
        _cooler = cooler;
        _ram = ram;
        _hardDrive = hardDrive;
        _videoCard = videoCard;
        _bios = bios;
        _builder = new ComputerBuilder();
        _wifi = wifi;
    }

    public Computer ComputerBuilder => _builder.Build();

    public Result Assemble()
    {
        if (!_builder.AddCase(_computerCase))
        {
            return new CanNotBuild();
        }

        if (!_builder.AddPowerSupply(_powerSupply))
        {
            return new CanNotBuild();
        }

        if (!_builder.AddMotherBoard(_motherBoard))
        {
            return new CanNotBuild();
        }

        if (!_builder.AddSsd(_ssd))
        {
            return new CanNotBuild();
        }

        if (!_builder.AddProcessor(_processor))
        {
            return new CanNotBuild();
        }

        if (!_builder.AddCooler(_cooler))
        {
            return new CanNotBuild();
        }

        if (!_builder.AddRam(_ram))
        {
            return new CanNotBuild();
        }

        if (!_builder.AddHardDrive(_hardDrive))
        {
            return new CanNotBuild();
        }

        if (!_builder.AddBios(_bios))
        {
            return new CanNotBuild();
        }

        _builder.AddVideoCard(_videoCard);
        _builder.AddWifi(_wifi);

        return new Success();
    }
}