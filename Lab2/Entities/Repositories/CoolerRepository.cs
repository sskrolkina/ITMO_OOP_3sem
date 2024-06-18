using System;
using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Components;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Cooler;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Repositories;

public class CoolerRepository : IRepository<ProcessorCoolingSystem>
{
    private readonly List<ProcessorCoolingSystem> _coolerList;

    public CoolerRepository()
    {
        _coolerList = new List<ProcessorCoolingSystem>();
        _coolerList.Add(new ProcessorCoolingSystem(
            "ID-Cooling SE-224",
            new Dimension(100, 100),
            new List<ProcessorSocket>() { new ProcessorSocket("LGA-1700") },
            new ThermalDesignPower(1900)));
        _coolerList.Add(new ProcessorCoolingSystem(
            "DEEPCOOL AG400",
            new Dimension(100, 100),
            new List<ProcessorSocket>() { new ProcessorSocket("LGA-1700") },
            new ThermalDesignPower(1000)));
    }

    public ProcessorCoolingSystem? FindByName(string? name)
    {
        return _coolerList.FirstOrDefault(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    public void Add(ProcessorCoolingSystem obj)
    {
        _coolerList.Add(obj);
    }
}