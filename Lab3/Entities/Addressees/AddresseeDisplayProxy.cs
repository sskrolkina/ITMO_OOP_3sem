using Itmo.ObjectOrientedProgramming.Lab3.Entities.Displays;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Results;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressees;

public class AddresseeDisplayProxy : Addressee
{
    private readonly IDisplay _display;

    public AddresseeDisplayProxy(IDisplay display)
    {
        _display = display;
    }

    public override Result? AcceptTheMessage(Message message)
    {
      _display.AcceptThMessage(message);
      return new MessageSent();
    }
}