using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Results;
using Itmo.ObjectOrientedProgramming.Lab3.Others;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Displays;

public class AmazingDisplayAdapter : IDisplay
{
    private readonly AmazingDisplay _display;

    public AmazingDisplayAdapter(AmazingDisplay display)
    {
        _display = display;
    }

    public Result AcceptThMessage(Message? message)
    {
        _display.AcceptThMessage(message);
        return new MessageHasArrived();
    }

    public void ShowMessage()
    {
       _display.ShowMessage();
    }

    public void Write(string text)
    {
        _display.Write(text);
    }
}