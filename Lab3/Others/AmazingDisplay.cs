using System;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Displays;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Results;

namespace Itmo.ObjectOrientedProgramming.Lab3.Others;

public class AmazingDisplay : IAmazingDisplay
{
    private readonly DisplayDriver _displayDriver;
    private Message? _message;

    public AmazingDisplay(int importanceLevel)
    {
        _displayDriver = new DisplayDriver();
    }

    public static void ConsoleClear()
    {
        DisplayDriver.ConsoleClear();
    }

    public static void ColourMessage(string colorName)
    {
        DisplayDriver.ColourMessage(colorName);
    }

    public Result AcceptThMessage(Message? message)
    {
        _message = message;
        return new MessageHasArrived();
    }

    public void ShowMessage()
    {
        Console.WriteLine(_message?.MessageBody.Body);
        Console.ResetColor();
    }

    public void Write(string text)
    {
       _displayDriver.Write(text);
    }
}