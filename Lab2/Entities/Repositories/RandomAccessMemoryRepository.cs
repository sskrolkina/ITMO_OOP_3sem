using System;
using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.RAM;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Repositories;

public class RandomAccessMemoryRepository : IRepository<RandomAccessMemory>
{
    private readonly List<RandomAccessMemory> _ramList;

    public RandomAccessMemoryRepository()
    {
        _ramList = new List<RandomAccessMemory>();
    }

    public RandomAccessMemory? FindByName(string? name)
    {
        return _ramList.FirstOrDefault(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    public void Add(RandomAccessMemory obj)
    {
        _ramList.Add(obj);
    }
}