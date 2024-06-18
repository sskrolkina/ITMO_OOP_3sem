using System;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Results;

namespace Itmo.ObjectOrientedProgramming.Lab3.Services;

public class ImportanceLevel : Addressee
{
    private readonly Addressee _addressee;

    public ImportanceLevel(Addressee addressee, int priorityLevel)
    {
        _addressee = addressee;
        PriorityLevel = priorityLevel;
    }

    private int PriorityLevel { get; }

    public override Result? AcceptTheMessage(Message? message)
    {
        ArgumentNullException.ThrowIfNull(message?.Header);
        if (message.ImportanceLevel >= PriorityLevel)
        {
            _addressee.AcceptTheMessage(message);
            return new MessageSent();
        }
        else
        {
            return new MessageNotSent();
        }
    }
}
