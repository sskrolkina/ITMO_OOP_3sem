using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.Results;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Validators;

public class ValidateBios : IComputerValidator
{
    private readonly Computer _computer;

    public ValidateBios(Computer computer)
    {
        _computer = computer;
    }

    public Result Validate()
    {
        if (_computer.BasicInputOutputSystem is null || _computer.Processor is null) return new CanNotStart();
        if (_computer.BasicInputOutputSystem.SupportedProcessors.Any(processor => processor == _computer.Processor.Name))
        {
            return new CanStart();
        }

        return new WrongBios();
    }
}