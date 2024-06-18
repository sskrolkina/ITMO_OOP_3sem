using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Results;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Displays;

public interface IDisplay
{
    Result AcceptThMessage(Message? message);
    void ShowMessage();
}