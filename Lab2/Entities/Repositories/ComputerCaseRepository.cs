using System;
using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.ComputerCases;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Repositories;

public class ComputerCaseRepository : IRepository<ComputerCase>
{
    private readonly List<ComputerCase> _caseList;

    public ComputerCaseRepository()
    {
        _caseList = new List<ComputerCase>();
    }

    public ComputerCase? FindByName(string? name)
    {
        return _caseList.FirstOrDefault(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    public void Add(ComputerCase obj)
    {
        _caseList.Add(obj);
    }
}