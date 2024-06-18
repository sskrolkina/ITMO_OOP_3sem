using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.BIOS;

public class BasicInputOutputSystem : IBasicInputOutputSystem
{
    public BasicInputOutputSystem(string name, ComponentType biosType, ProductVersion biosVersion, IEnumerable<string> processors)
    {
        BiosType = biosType;
        BiosVersion = biosVersion;
        SupportedProcessors = processors.ToArray();
        Name = name;
    }

    public ComponentType BiosType { get; }
    public ProductVersion BiosVersion { get; }
    public string Name { get; }
    public IReadOnlyCollection<string> SupportedProcessors { get; }
}