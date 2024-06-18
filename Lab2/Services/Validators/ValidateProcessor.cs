using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.Results;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Validators;

public class ValidateProcessor : IComputerValidator
{
    private readonly Computer _computer;

    public ValidateProcessor(Computer computer)
    {
        _computer = computer;
    }

    public Result Validate()
    {
        if (_computer.Motherboard?.ProcessorSocket.SocketType != _computer.Processor?.Socket.SocketType)
        {
            return new WrongSocket();
        }

        if (_computer.Processor?.VideoCore.Availability == false && _computer.VideoCard is null)
        {
            return new NoVideoCore();
        }

        return new CanStart();
    }
}