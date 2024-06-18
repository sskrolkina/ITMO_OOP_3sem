using System;
using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.WiFi;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Repositories;

public class WiFiRepository : IRepository<WifiAdapter>
{
    private readonly List<WifiAdapter> _adapters;

    public WiFiRepository()
    {
        _adapters = new List<WifiAdapter>();
    }

    public WifiAdapter? FindByName(string? name)
    {
        return _adapters.FirstOrDefault(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    public void Add(WifiAdapter obj)
    {
        _adapters.Add(obj);
    }
}