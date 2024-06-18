namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public record Health
{
    public Health(int health)
    {
        ShipHealth = health;
    }

    public int ShipHealth { get; set; }
}