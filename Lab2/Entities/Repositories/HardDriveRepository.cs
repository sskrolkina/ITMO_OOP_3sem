using System;
using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.HardDrives;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Repositories;

public class HardDriveRepository : IRepository<HardDrive>
{
    private readonly List<HardDrive> _driveList;

    public HardDriveRepository()
    {
        _driveList = new List<HardDrive>();
    }

    public HardDrive? FindByName(string? name)
    {
        return _driveList.FirstOrDefault(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    public void Add(HardDrive obj)
    {
        _driveList.Add(obj);
    }
}