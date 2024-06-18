using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.Results;
using Itmo.ObjectOrientedProgramming.Lab2.Services.Validators;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services;

public class Validator
{
    private readonly List<IComputerValidator> _validators;

    public Validator(Computer computer)
    {
        _validators = new List<IComputerValidator>();
        _validators.Add(new ValidateSystemPower(computer));
        _validators.Add(new ValidateProcessor(computer));
        _validators.Add(new ValidateBios(computer));
        _validators.Add(new ValidateRam(computer));
        _validators.Add(new ValidateVideoCard(computer));
        _validators.Add(new ValidateMotherboard(computer));
        _validators.Add(new ValidateSsd(computer));
        _validators.Add(new ValidateComputerCase(computer));
        _validators.Add(new ValidateCooler(computer));
        _validators.Add(new ValidateXmp(computer));
        _validators.Add(new ValidateWifi(computer));
    }

    public Result? ErrorReason { get; private set; }

    public Result GerRuslt()
    {
        foreach (IComputerValidator check in _validators)
        {
            Result validationResult = check.Validate();
            if (validationResult is CanStart) continue;
            if (validationResult is CanStartButNotEnoughTdp)
            {
                ErrorReason = new CanStartButNotEnoughTdp();
                return new GoodBuild();
            }

            ErrorReason = validationResult;
            return new BadBuild();
        }

        ErrorReason = null;
        return new GoodBuild();
    }
}