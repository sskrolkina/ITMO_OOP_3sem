using System;
using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.SSD;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Repositories;

public class SsdRepository : IRepository<SsdDrive>
{
    private readonly List<SsdDrive> _ssdList;

    public SsdRepository()
    {
        _ssdList = new List<SsdDrive>();
    }

    public SsdDrive? FindByName(string? name)
    {
        return _ssdList.FirstOrDefault(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    public void Add(SsdDrive obj)
    {
        _ssdList.Add(obj);
    }
}