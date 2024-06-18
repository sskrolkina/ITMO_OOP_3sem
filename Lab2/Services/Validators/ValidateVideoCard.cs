using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.Results;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Validators;

public class ValidateVideoCard : IComputerValidator
{
    private readonly Computer _computer;

    public ValidateVideoCard(Computer computer)
    {
        _computer = computer;
    }

    public Result Validate()
    {
        if (_computer.Motherboard is null || _computer.VideoCard is null)
            return new CanNotStart();

        if (_computer.Motherboard.PeripheralComponentInterconnectExpress.Version ==
            _computer.VideoCard.PeripheralComponentInterconnectExpress.Version)
        {
            return new CanStart();
        }

        return new WrongPciE();
    }
}