using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.Results;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Validators;

public class ValidateMotherboard : IComputerValidator
{
    private readonly Computer _computer;

    public ValidateMotherboard(Computer computer)
    {
        _computer = computer;
    }

    public Result Validate()
    {
        if (_computer.Motherboard?.BiosType.Type != _computer.BasicInputOutputSystem?.BiosType.Type)
        {
            return new WrongBios();
        }

        return new CanStart();
    }
}