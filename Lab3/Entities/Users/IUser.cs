using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Models;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Results;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Users;

public interface IUser
{
    Result AcceptThMessage(Message message);
    void SendMessageToUser(Message message);
    MessageStatus CheckReadMessage(string name);
    MessageStatus ReadMessage(string name);
}