using System;
using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Motherboards;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Repositories;

public class MotherBoardRepository : IRepository<Motherboard>
{
    private readonly List<Motherboard> _motherList;

    public MotherBoardRepository()
    {
        _motherList = new List<Motherboard>();
    }

    public Motherboard? FindByName(string? name)
    {
        return _motherList.FirstOrDefault(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    public void Add(Motherboard obj)
    {
        _motherList.Add(obj);
    }
}