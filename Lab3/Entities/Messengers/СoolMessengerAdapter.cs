using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Results;
using Itmo.ObjectOrientedProgramming.Lab3.Others;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Messengers;

public class СoolMessengerAdapter : IMessenger
{
    private readonly ICoolMessenger _coolMessenger;

    public СoolMessengerAdapter(ICoolMessenger coolMessenger)
    {
        _coolMessenger = coolMessenger;
    }

    public Result AcceptThMessage(Message? message)
    {
        _coolMessenger.AcceptThMessage(message);
        return new MessageHasArrived();
    }

    public void ShowMessage()
    {
        _coolMessenger.ShowMessage();
    }
}