using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.Results;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Validators;

public class ValidateRam : IComputerValidator
{
    private readonly Computer _computer;

    public ValidateRam(Computer computer)
    {
        _computer = computer;
    }

    public Result Validate()
    {
        if (_computer.Motherboard?.DoubleDataRate.Version != _computer.RandomAccessMemory?.DoubleDataRate.Version)
        {
            return new WrongDdr();
        }

        return new CanStart();
    }
}