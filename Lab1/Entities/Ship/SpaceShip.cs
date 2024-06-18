using Itmo.ObjectOrientedProgramming.Lab1.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Engine;
using Itmo.ObjectOrientedProgramming.Lab1.Services.Outcomes;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ship;

public abstract class SpaceShip
{
    public abstract Fuel? ShipFuel { get; set; }
    public abstract Travel CrewStatus { get; }
    public abstract Travel ShipStatus { get; }
    public abstract IEngine? PulseEngine { get; }
    public abstract IEngine? JumpEngine { get; }
    public abstract double? AmountOfSpentFuel { get; }
    public abstract Credits? Credits { get; set; }
    public abstract double PulseBoost();
    public abstract double JumpBoost();
    public abstract void DeflectObstacle(Damage damage);
}