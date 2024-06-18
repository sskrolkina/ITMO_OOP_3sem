using System;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Topics;

public class Topic
{
    private readonly Message _message;
    private readonly Addressee _addressee;
    private string _name;

    public Topic(string name, Addressee addressee, Message message)
    {
        ArgumentNullException.ThrowIfNull(addressee);
        _name = name;
        _message = message;
        _addressee = addressee;
    }

    public void SendMessage()
    {
        _addressee.AcceptTheMessage(_message);
    }
}