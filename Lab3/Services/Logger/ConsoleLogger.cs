using System;

namespace Itmo.ObjectOrientedProgramming.Lab3.Services.Logger;

public class ConsoleLogger : ILogger
{
    public void GoodLog(string name)
    {
        Console.WriteLine(name + "is sent");
    }

    public void BadLog(string name)
    {
        Console.WriteLine(name + "isn't sent");
    }
}