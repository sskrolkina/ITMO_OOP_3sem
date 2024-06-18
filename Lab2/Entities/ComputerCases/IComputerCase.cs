using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.ComputerCases;

public interface IComputerCase : IComponent
{
    Dimension VideoCardSize { get; }
    Dimension CaseSize { get; }
    IEnumerable<FormFactor> MotherBoardsFormFactor { get; }
}