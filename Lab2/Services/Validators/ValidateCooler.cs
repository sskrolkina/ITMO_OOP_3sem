using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Components;
using Itmo.ObjectOrientedProgramming.Lab2.Services.Results;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Validators;

public class ValidateCooler : IComputerValidator
{
    private readonly Computer _computer;
    private readonly ComputerTdp _tdp;

    public ValidateCooler(Computer computer)
    {
        _computer = computer;
        _tdp = new ComputerTdp(computer);
    }

    public Result Validate()
    {
        if (_computer.ComputerCase?.CaseSize.Height <= _computer.ProcessorCoolingSystem?.CoolerSize.Height ||
            _computer.ComputerCase?.CaseSize.Length <= _computer.ProcessorCoolingSystem?.CoolerSize.Length)
        {
            return new SmallComputerCase();
        }

        if (_computer.ProcessorCoolingSystem == null || _computer.Processor == null) return new WrongSocket();
        foreach (ProcessorSocket socket in _computer.ProcessorCoolingSystem.SupportedSockets)
        {
            if (_computer.Processor.Socket.SocketType != socket.SocketType) continue;
            if (_computer.ProcessorCoolingSystem.MaximumThermalDesignPower.Power < _tdp.TotalTdp())
            {
                return new CanStartButNotEnoughTdp();
            }

            return new CanStart();
        }

        return new WrongSocket();
    }
}