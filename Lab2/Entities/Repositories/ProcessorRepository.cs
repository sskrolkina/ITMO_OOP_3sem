using System;
using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Processors;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Repositories;

public class ProcessorRepository : IRepository<Processor>
{
    private readonly List<Processor> _cpuList;

    public ProcessorRepository()
    {
        _cpuList = new List<Processor>();
    }

    public Processor? FindByName(string? name)
    {
        return _cpuList.FirstOrDefault(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    public void Add(Processor obj)
    {
        _cpuList.Add(obj);
    }
}