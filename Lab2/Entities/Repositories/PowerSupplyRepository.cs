using System;
using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.PowerSupplies;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Repositories;

public class PowerSupplyRepository : IRepository<PowerSupply>
{
    private readonly List<PowerSupply> _powerSuppliesList;

    public PowerSupplyRepository()
    {
        _powerSuppliesList = new List<PowerSupply>();
    }

    public PowerSupply? FindByName(string? name)
    {
        return _powerSuppliesList.FirstOrDefault(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    public void Add(PowerSupply obj)
    {
        _powerSuppliesList.Add(obj);
    }
}