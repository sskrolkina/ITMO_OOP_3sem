using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.Results;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Validators;

public class ValidateSystemPower : IComputerValidator
{
    private readonly Computer _computer;
    private readonly ComputerTdp _tdp;

    public ValidateSystemPower(Computer computer)
    {
        _computer = computer;
        _tdp = new ComputerTdp(computer);
    }

    public Result Validate()
    {
        if (_computer.PowerSupply?.MaximumPowerConsumption.Power < _tdp.TotalTdp())
        {
            return new CanStartButNotEnoughTdp();
        }

        return new CanStart();
    }
}