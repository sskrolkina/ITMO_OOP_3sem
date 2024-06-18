using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Deflectors;

public class SecondTypeOfDeflector : IDeflector
{
    private const int DeflectorStrength = 50;
    private readonly Health _deflectorHealth;
    private Damage _damage;

    // ReSharper disable once ConvertConstructorToMemberInitializers
    public SecondTypeOfDeflector()
    {
        _deflectorHealth = new Health(DeflectorStrength);
        _damage = new Damage(0);
    }

    public int Strength
    {
        get => _deflectorHealth.ShipHealth;
        set => _deflectorHealth.ShipHealth = value;
    }

    public Damage DeflectObstacle(Damage damage)
    {
        ArgumentNullException.ThrowIfNull(damage);
        if (_deflectorHealth.ShipHealth - damage.ExtraDamage <= 0)
        {
            _damage = _damage with { ExtraDamage = _damage.ExtraDamage - _deflectorHealth.ShipHealth };
        }
        else
        {
            _deflectorHealth.ShipHealth -= damage.ExtraDamage;
            _damage = _damage with { ExtraDamage = _damage.ExtraDamage };
        }

        return _damage;
    }
}