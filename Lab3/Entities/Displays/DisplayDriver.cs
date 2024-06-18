using System;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Displays;

public class DisplayDriver
{
    private string? _message;
    public static void ConsoleClear()
    {
        Console.Clear();
    }

    public static void ColourMessage(string colorName)
    {
        Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colorName, true);
    }

    public void Write(string text)
    {
        _message = text;
    }
}