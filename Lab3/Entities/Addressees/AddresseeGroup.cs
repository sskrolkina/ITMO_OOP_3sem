using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Results;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Addressees;

public class AddresseeGroup : Addressee
{
    private readonly IReadOnlyCollection<Addressee> _addressees;
    private readonly GroupResults? _groupResults;

    public AddresseeGroup(IReadOnlyCollection<Addressee> addressees)
    {
        _groupResults = new GroupResults(null);
        _addressees = addressees;
    }

    public override Result? AcceptTheMessage(Message message)
    {
        foreach (Addressee addressee in _addressees)
        {
            ArgumentNullException.ThrowIfNull(_groupResults);
            _groupResults.GroupResult?.Add(addressee.AcceptTheMessage(message));
        }

        return _groupResults;
    }
}