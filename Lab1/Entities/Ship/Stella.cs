using System;
using Itmo.ObjectOrientedProgramming.Lab1.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Engine;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Engine.JumpEngine;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Engine.PulseEngine;
using Itmo.ObjectOrientedProgramming.Lab1.Models.ShipHull;
using Itmo.ObjectOrientedProgramming.Lab1.Services.Outcomes;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ship;

public class Stella : SpaceShip
{
    private const int StellaWeight = 25;
    private readonly IPulseEngine? _pulseEngine;
    private readonly IJumpEngine? _jumpEngine;
    private readonly IDeflector _deflector;
    private readonly IPhotonicDeflector? _photonicDeflector;
    private readonly IShipHull _hull;
    private readonly Fuel? _amountOfSpentFuel;
    private Travel _crewStatus;
    private Travel _shipStatus;

    public Stella(IPhotonicDeflector? deflector)
    {
        _pulseEngine = new CPulseEngine();
        _jumpEngine = new Omega();
        _deflector = new FirstTypeOfDeflector();
        _hull = new FirstTypeHull();
        _crewStatus = new CrewIsAlive();
        _shipStatus = new ShipIsFine();
        _amountOfSpentFuel = new Fuel();
        _photonicDeflector = deflector;
        deflector?.Add(_deflector);
    }

    public override Travel CrewStatus => _crewStatus;
    public override Travel ShipStatus => _shipStatus;
    public override IEngine? PulseEngine => _pulseEngine;
    public override IEngine? JumpEngine => _jumpEngine;
    public override Fuel? ShipFuel { get; set; }
    public override Credits? Credits { get; set; }
    public override double? AmountOfSpentFuel => _amountOfSpentFuel?.FuelQuantity;
    public override double PulseBoost()
    {
        ArgumentNullException.ThrowIfNull(_amountOfSpentFuel);
        if (_pulseEngine == null) return 0;
        _pulseEngine.SpentFuel();
        _amountOfSpentFuel.FuelQuantity += _pulseEngine.AmountOfFuel.FuelQuantity;
        return _pulseEngine.Boost * StellaWeight;
    }

    public override double JumpBoost()
    {
        ArgumentNullException.ThrowIfNull(_amountOfSpentFuel);
        if (_jumpEngine == null) return 0;
        _jumpEngine.SpentFuel();
        _amountOfSpentFuel.FuelQuantity += _jumpEngine.AmountOfFuel.FuelQuantity;
        return _jumpEngine.Boost * StellaWeight;
    }

    public override void DeflectObstacle(Damage damage)
    {
        ArgumentNullException.ThrowIfNull(damage);
        if (_photonicDeflector is null && damage.ExtraDamage >= damage.LightDamage)
        {
            _crewStatus = new CrewWasKilled();
        }
        else
        {
            if (_hull.Attack(_deflector.DeflectObstacle(damage))) return;
            _shipStatus = new ShipCollapsed();
            _crewStatus = new CrewWasKilled();
        }
    }
}