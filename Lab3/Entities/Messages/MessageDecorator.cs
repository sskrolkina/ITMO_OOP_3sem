using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;

public class MessageDecorator : Message
{
    private Header _header;
    private MessageBody _body;
    private int _importanceLevel;

    public MessageDecorator(Header header, MessageBody body, int importanceLevel)
        : base(header, body, importanceLevel)
    {
        _header = header;
        _body = body;
        _importanceLevel = importanceLevel;
        ReadStatus = new MessageNotRead();
    }

    public MessageStatus ReadStatus { get; private set; }

    public void ReadMessage()
    {
        ReadStatus = new MessageRead();
    }
}