using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.Results;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Validators;

public class ValidateXmp : IComputerValidator
{
    private readonly Computer _computer;

    public ValidateXmp(Computer computer)
    {
        _computer = computer;
    }

    public Result Validate()
    {
        if (_computer.RandomAccessMemory?.XmpProfile is not null)
        {
            if (_computer.RandomAccessMemory?.Frequency.CoreFrequencies <=
                _computer.RandomAccessMemory?.XmpProfile.Frequency.CoreFrequencies || _computer.Motherboard?.XmpProfile is not null)
            {
                return new CanStart();
            }

            return new WrongXmp();
        }

        return new CanStart();
    }
}