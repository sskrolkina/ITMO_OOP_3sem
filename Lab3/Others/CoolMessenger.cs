using System;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Results;

namespace Itmo.ObjectOrientedProgramming.Lab3.Others;

public class CoolMessenger : ICoolMessenger
{
    private Message? _message;

    public Result AcceptThMessage(Message? message)
    {
        _message = message;
        return new MessageSent();
    }

    public void ShowMessage()
    {
        Console.WriteLine("Messenger: " + _message?.MessageBody);
    }
}