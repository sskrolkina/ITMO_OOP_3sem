using System;
using Itmo.ObjectOrientedProgramming.Lab1.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Engine;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Engine.PulseEngine;
using Itmo.ObjectOrientedProgramming.Lab1.Models.ShipHull;
using Itmo.ObjectOrientedProgramming.Lab1.Services.Outcomes;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ship;

public class PleasureShuttle : SpaceShip
{
    private const int PleasureShuttleWeight = 25;
    private readonly IPulseEngine? _engine;
    private readonly IShipHull _hull;
    private readonly Fuel? _amountOfSpentFuel;
    private Travel _crewStatus;
    private Travel _shipStatus;

    public PleasureShuttle()
    {
        _engine = new EPulseEngine();
        _hull = new FirstTypeHull();
        _crewStatus = new CrewIsAlive();
        _shipStatus = new ShipIsFine();
        _amountOfSpentFuel = new Fuel();
    }

    public override Travel CrewStatus => _crewStatus;
    public override Travel ShipStatus => _shipStatus;
    public override IEngine? PulseEngine => _engine;
    public override IEngine? JumpEngine => null;
    public override Fuel? ShipFuel { get; set; }
    public override Credits? Credits { get; set; }
    public override double? AmountOfSpentFuel => _amountOfSpentFuel?.FuelQuantity;

    public override double PulseBoost()
    {
        ArgumentNullException.ThrowIfNull(_amountOfSpentFuel);
        if (_engine == null) return 0;
        _engine.SpentFuel();
        _amountOfSpentFuel.FuelQuantity += _engine.AmountOfFuel.FuelQuantity;
        return _engine.Boost * PleasureShuttleWeight;
    }

    public override double JumpBoost()
    {
        return 0;
    }

    public override void DeflectObstacle(Damage damage)
    {
        ArgumentNullException.ThrowIfNull(damage);
        if (damage.ExtraDamage >= damage.LightDamage)
        {
            _crewStatus = new CrewWasKilled();
        }
        else
        {
            if (_hull.Attack(damage)) return;
            _shipStatus = new ShipCollapsed();
            _crewStatus = new CrewWasKilled();
        }
    }
}