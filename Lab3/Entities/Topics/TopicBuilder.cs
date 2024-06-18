using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Displays;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messengers;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Users;
using Itmo.ObjectOrientedProgramming.Lab3.Models;
using Itmo.ObjectOrientedProgramming.Lab3.Services.Logger;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Topics;

public class TopicBuilder
{
    private readonly string _name;
    private readonly AddresseeBuilder _addresseeBuilder = new AddresseeBuilder();
    private Message _message;

    public TopicBuilder(string name, Message message)
    {
        _name = name;
        _message = message;
    }

    public TopicBuilder ToUser(IUser user)
    {
        this._addresseeBuilder.ToUser(user);
        ArgumentNullException.ThrowIfNull(_message.Header);
        ArgumentNullException.ThrowIfNull(_message.ImportanceLevel);
        var decorator = new MessageDecorator(
            new Header(_message.Header),
            new MessageBody(_message.MessageBody.Body),
            _message.ImportanceLevel);
        _message = decorator;
        return this;
    }

    public TopicBuilder ToMessenger(IMessenger messenger)
    {
        this._addresseeBuilder.ToMessenger(messenger);
        return this;
    }

    public TopicBuilder ToDisplay(IDisplay display)
    {
        this._addresseeBuilder.ToDisplay(display);
        return this;
    }

    public TopicBuilder ToGroup(IReadOnlyCollection<Addressee> addressees)
    {
        this._addresseeBuilder.GroupAddressee(addressees);
        return this;
    }

    public TopicBuilder WithLogger(ILogger logger)
    {
        this._addresseeBuilder.WithLogger(logger);
        return this;
    }

    public TopicBuilder WithImportanceLevel(int level)
    {
        this._addresseeBuilder.WithImportanceLevel(level);
        return this;
    }

    public Topic Build()
    {
        ArgumentNullException.ThrowIfNull(_addresseeBuilder.Build);
        return new Topic(_name, _addresseeBuilder.Build, _message);
    }
}