using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Results;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressees;

public abstract class Addressee
{
    public abstract Result? AcceptTheMessage(Message message);
}