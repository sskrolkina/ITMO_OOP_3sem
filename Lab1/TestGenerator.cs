using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ship;
using Itmo.ObjectOrientedProgramming.Lab1.Services.Outcomes;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public static class TestGenerator
{
    public static IEnumerable<object[]> ShipsStatus()
    {
        yield return new object[] { new Vaclas(null), typeof(ShipCollapsed) };
        yield return new object[] { new Augur(null), typeof(ShipIsFine) };
        yield return new object[] { new Meridian(null), typeof(ShipIsFine) };
    }
}