using System;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Results;

namespace Itmo.ObjectOrientedProgramming.Lab3.Services.Logger;

public class AddresseeLoggerDecorator : Addressee
{
    private readonly ILogger _consoleLogger;
    private readonly ILogger _fileLogger;
    private readonly Addressee _addressee;
    private Result? _result;

    public AddresseeLoggerDecorator(Addressee addressee, ILogger logger)
    {
        _addressee = addressee;
        _consoleLogger = logger;
        _fileLogger = logger;
    }

    public override Result? AcceptTheMessage(Message? message)
    {
        ArgumentNullException.ThrowIfNull(message?.Header);
        _result = _addressee.AcceptTheMessage(message);
        _consoleLogger.GoodLog(message.Header);
        _fileLogger.GoodLog(message.Header);
        return _result;
    }
}