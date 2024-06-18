using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.Results;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Validators;

public class ValidateWifi : IComputerValidator
{
    private readonly Computer _computer;

    public ValidateWifi(Computer computer)
    {
        _computer = computer;
    }

    public Result Validate()
    {
        if (_computer.Motherboard?.WiFi is not null && _computer.WiFi is not null)
        {
            return new CanNotStart();
        }

        if (_computer.Motherboard?.PeripheralComponentInterconnectExpress.Version != _computer.WiFi?.PciE.Version)
        {
            return new WrongPciE();
        }

        return new CanStart();
    }
}