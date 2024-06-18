using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Displays;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messengers;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Users;
using Itmo.ObjectOrientedProgramming.Lab3.Services;
using Itmo.ObjectOrientedProgramming.Lab3.Services.Logger;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressees;

public class AddresseeBuilder
{
    public Addressee? Build { get; private set; }

    public void WithImportanceLevel(int importanceLevel)
    {
        ArgumentNullException.ThrowIfNull(Build);
        var addresseeWithFilter = new ImportanceLevel(Build, importanceLevel);
        Build = addresseeWithFilter;
    }

    public void WithLogger(ILogger logger)
    {
        ArgumentNullException.ThrowIfNull(Build);
        var decorator = new AddresseeLoggerDecorator(Build, logger);
        Build = decorator;
    }

    public void ToUser(IUser user)
    {
        Build = new AddresseeUserProxy(user);
    }

    public void ToMessenger(IMessenger messenger)
    {
        Build = new AddresseeMessengerProxy(messenger);
    }

    public void ToDisplay(IDisplay display)
    {
        Build = new AddresseeDisplayProxy(display);
    }

    public void GroupAddressee(IReadOnlyCollection<Addressee> addressees)
    {
        Build = new AddresseeGroup(addressees);
    }
}