using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;

public class Message
{
    private readonly Header? _header;

    public Message(Header header, MessageBody body, int importanceLevel)
    {
        _header = header;
        MessageBody = body;
        ImportanceLevel = importanceLevel;
    }

    public int ImportanceLevel { get; }

    public MessageBody MessageBody { get; }

    public string? Header => _header?.HeaderMessage;
}