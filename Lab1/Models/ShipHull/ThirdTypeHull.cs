using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.ShipHull;

public class ThirdTypeHull : IShipHull
{
    private const int HullStrength = 200;
    private readonly Health _hullHealth;
    public ThirdTypeHull()
    {
        _hullHealth = new Health(HullStrength);
    }

    public bool Attack(Damage damage)
    {
        ArgumentNullException.ThrowIfNull(damage);
        if (_hullHealth.ShipHealth - damage.ExtraDamage <= 0)
        {
            return false;
        }
        else
        {
            _hullHealth.ShipHealth -= damage.ExtraDamage;
            return true;
        }
    }
}