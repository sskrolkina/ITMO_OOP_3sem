using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ship;
using Itmo.ObjectOrientedProgramming.Lab1.Services.Outcomes;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services.Route;

public class FindOptimalShip
{
    private readonly SpaceShip _firstShip;
    private readonly SpaceShip _secondShip;
    private Travel? _firstSpaceShip;
    private Travel? _secondSpaceShip;
    public FindOptimalShip(SpaceShip firstShip, SpaceShip secondShip)
    {
        _firstShip = firstShip;
        _secondShip = secondShip;
    }

    public Travel? FirstShip => _firstSpaceShip;
    public Travel? SecondShip => _secondSpaceShip;

    public void OptimalForPulseEngine()
    {
        if (_firstShip.AmountOfSpentFuel < _secondShip.AmountOfSpentFuel)
        {
            _firstSpaceShip = new OptimalShip();
            _secondSpaceShip = new NotOptimalShip();
        }
        else
        {
            _firstSpaceShip = new NotOptimalShip();
            _secondSpaceShip = new OptimalShip();
        }
    }

    public void OptimalForJumpEngine()
    {
        if (_firstShip.JumpBoost() > _secondShip.JumpBoost())
        {
            _firstSpaceShip = new OptimalShip();
            _secondSpaceShip = new NotOptimalShip();
        }
        else
        {
            _firstSpaceShip = new NotOptimalShip();
            _secondSpaceShip = new OptimalShip();
        }
    }

    public void FastestShipWithPulseEngine()
    {
        if (_firstShip.PulseBoost() < _secondShip.PulseBoost())
        {
            _firstSpaceShip = new OptimalShip();
            _secondSpaceShip = new NotOptimalShip();
        }
        else
        {
            _firstSpaceShip = new NotOptimalShip();
            _secondSpaceShip = new OptimalShip();
        }
    }
}