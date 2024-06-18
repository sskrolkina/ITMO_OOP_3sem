using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.Results;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Validators;

public class ValidateSsd : IComputerValidator
{
    private readonly Computer _computer;

    public ValidateSsd(Computer computer)
    {
        _computer = computer;
    }

    public Result Validate()
    {
        if (_computer.SsdDrive?.ConnectionType.Type ==
            _computer.Motherboard?.PeripheralComponentInterconnectExpress.Version ||
            _computer.SsdDrive?.ConnectionType.Type == _computer.Motherboard?.SerialAdvancedTechnologyAttachment.Version)
        {
            return new CanStart();
        }

        return new WrongSsd();
    }
}