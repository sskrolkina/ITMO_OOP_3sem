using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.BIOS;

public interface IBasicInputOutputSystem : IComponent
{
    ComponentType BiosType { get; }
    ProductVersion BiosVersion { get; }
    IReadOnlyCollection<string> SupportedProcessors { get; }
}