using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.Results;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Validators;

public class ValidateComputerCase : IComputerValidator
{
    private readonly Computer _computer;

    public ValidateComputerCase(Computer computer)
    {
        _computer = computer;
    }

    public Result Validate()
    {
        if (_computer.ComputerCase is null) return new CanNotStart();
        if (_computer.ComputerCase.MotherBoardsFormFactor.Any(form =>
                form.Form == _computer.Motherboard?.FormFactor.Form) &&
            _computer.ComputerCase.VideoCardSize.Height >= _computer.VideoCard?.SizeParameter.Height &&
            _computer.ComputerCase.VideoCardSize.Length >= _computer.VideoCard.SizeParameter.Length)
        {
            return new CanStart();
        }

        return new SmallComputerCase();
    }
}