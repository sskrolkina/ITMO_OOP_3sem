using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Users;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Results;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressees;

public class AddresseeUserProxy : Addressee
{
    private readonly IUser _user;

    public AddresseeUserProxy(IUser user)
    {
        _user = user;
    }

    public override Result? AcceptTheMessage(Message message)
    {
        _user.AcceptThMessage(message);

        return new MessageSent();
    }
}