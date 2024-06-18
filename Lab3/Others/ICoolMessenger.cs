using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Results;

namespace Itmo.ObjectOrientedProgramming.Lab3.Others;

public interface ICoolMessenger
{
    Result AcceptThMessage(Message? message);
    void ShowMessage();
}