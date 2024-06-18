using System;
using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.BIOS;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Repositories;

public class BiosRepository : IRepository<BasicInputOutputSystem>
{
    private readonly List<BasicInputOutputSystem> _biosList;

    public BiosRepository()
    {
        _biosList = new List<BasicInputOutputSystem>();
    }

    public BasicInputOutputSystem? FindByName(string? name)
    {
        return _biosList.FirstOrDefault(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    public void Add(BasicInputOutputSystem obj)
    {
        _biosList.Add(obj);
    }
}