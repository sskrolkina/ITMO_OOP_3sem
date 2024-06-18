using System;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public class AntiNitrateEmitter
{
    private readonly IObstacles _whale;

    public AntiNitrateEmitter()
    {
        _whale = new CosmoWhale();
    }

    public int AntiNitrate(Damage damage)
    {
        ArgumentNullException.ThrowIfNull(damage);
        return (damage.ExtraDamage / _whale.Damage) * _whale.Damage;
    }
}