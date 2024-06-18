using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Results;

public class GroupResults : Result
{
    public GroupResults(IList<Result?>? groupResult)
    {
        GroupResult = groupResult;
    }

    public IList<Result?>? GroupResult { get; }
}