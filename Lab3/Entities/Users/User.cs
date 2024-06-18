using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Models;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Results;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Users;

public class User : IUser
{
    private readonly List<MessageDecorator> _messages = new List<MessageDecorator>();

    public Result AcceptThMessage(Message message)
    {
        _messages?.Add((MessageDecorator)message);
        return new MessageHasArrived();
    }

    public void SendMessageToUser(Message message)
    {
        _messages.Add((MessageDecorator)message);
    }

    public MessageStatus CheckReadMessage(string name)
    {
        foreach (MessageDecorator messages in _messages)
        {
            if (messages.Header != name) continue;
            if (messages.ReadStatus is MessageRead)
            {
                return new MessageRead();
            }

            return new MessageNotRead();
        }

        return new NoNeedMessage();
    }

    public MessageStatus ReadMessage(string name)
    {
        foreach (MessageDecorator messages in _messages)
        {
            if (messages.Header != name) continue;
            if (messages.ReadStatus is MessageRead)
            {
                return new MessageAlreadyRead();
            }

            messages.ReadMessage();
            return new MessageRead();
        }

        return new NoNeedMessage();
    }
}