using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ship;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services;

public class FuelExchange
{
    private const int ActivePlasmaPrise = 10;
    private const double GravitonMatterPrise = 30;
    private readonly SpaceShip _ship;

    public FuelExchange(SpaceShip ship)
    {
        _ship = ship;
    }

    public void BuyFuel()
    {
        if (_ship.PulseEngine is not null)
        {
            if (_ship.Credits == null || _ship.ShipFuel == null) return;
            _ship.ShipFuel.FuelQuantity += _ship.Credits.AmountOfCredits / GravitonMatterPrise;
            _ship.Credits = new Credits(AmountOfCredits: (_ship.Credits.AmountOfCredits / GravitonMatterPrise) * GravitonMatterPrise);
        }
        else
        {
            if (_ship.Credits == null || _ship.ShipFuel == null) return;
            _ship.ShipFuel.FuelQuantity += _ship.Credits.AmountOfCredits / ActivePlasmaPrise;
            _ship.Credits = new Credits(AmountOfCredits: (_ship.Credits.AmountOfCredits / GravitonMatterPrise) * GravitonMatterPrise);
        }
    }
}