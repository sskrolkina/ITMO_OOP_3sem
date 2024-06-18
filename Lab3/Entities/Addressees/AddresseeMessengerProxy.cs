using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messengers;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Results;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressees;

public class AddresseeMessengerProxy : Addressee
{
    private readonly IMessenger _messenger;

    public AddresseeMessengerProxy(IMessenger messenger)
    {
        _messenger = messenger;
    }

    public override Result? AcceptTheMessage(Message message)
    {
        _messenger.AcceptThMessage(message);
        return new MessageSent();
    }
}