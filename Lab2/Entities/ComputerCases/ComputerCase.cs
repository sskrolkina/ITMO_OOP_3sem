using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.ComputerCases;

public class ComputerCase : IComputerCase
{
    public ComputerCase(string name, Dimension videoCardSize, Dimension caseSize, IEnumerable<FormFactor> motherBoardsFormFactor)
    {
        VideoCardSize = videoCardSize;
        CaseSize = caseSize;
        MotherBoardsFormFactor = motherBoardsFormFactor;
        Name = name;
    }

    public Dimension VideoCardSize { get; }
    public Dimension CaseSize { get; }
    public IEnumerable<FormFactor> MotherBoardsFormFactor { get; }
    public string Name { get; }
}