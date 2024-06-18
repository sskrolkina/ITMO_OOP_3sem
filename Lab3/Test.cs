using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messengers;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Topics;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Users;
using Itmo.ObjectOrientedProgramming.Lab3.Models;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Results;
using Itmo.ObjectOrientedProgramming.Lab3.Others;
using Itmo.ObjectOrientedProgramming.Lab3.Services.Logger;
using NSubstitute;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class Test
{
    [Fact]
    public void AllUnread()
    {
        // Arrange
        var message = new Message(new Header("kaka"), new MessageBody("cool kaka"), 10);
        var message2 = new MessageDecorator(new Header("lol"), new MessageBody("kek"), 9);
        var user = new User();
        Topic topic = new TopicBuilder("super", message).ToUser(user).WithImportanceLevel(10).Build();

        // Act
        topic.SendMessage();
        user.SendMessageToUser(message2);

        // Assert
        Assert.IsType<MessageNotRead>(user.CheckReadMessage("kaka"));
        Assert.IsType<MessageNotRead>(user.CheckReadMessage("lol"));
    }

    [Fact]
    public void ReadMessage()
    {
        // Arrange
        var message = new Message(new Header("kaka"), new MessageBody("cool kaka"), 10);
        var cool = new TopicBuilder("super", message);
        var user = new User();

        // Act
        cool.ToUser(user);
        cool.Build().SendMessage();

        // Assert
        Assert.IsType<MessageNotRead>(user.CheckReadMessage("kaka"));
        Assert.IsType<MessageRead>(user.ReadMessage("kaka"));
        Assert.IsType<MessageRead>(user.CheckReadMessage("kaka"));
    }

    [Fact]
    public void DoubleCheck()
    {
        // Arrange
        var message = new Message(new Header("kaka"), new MessageBody("cool kaka"), 10);
        var cool = new TopicBuilder("super", message);
        var user = new User();

        // Act
        cool.ToUser(user);
        cool.Build().SendMessage();
        user.ReadMessage("kaka");

        // Assert
        Assert.IsType<MessageAlreadyRead>(user.ReadMessage("kaka"));
    }

    [Fact]
    public void DidNotReach()
    {
        // Arrange
        var message = new Message(new Header("kaka"), new MessageBody("cool kaka"), 5);
        IUser user = Substitute.For<IUser>();
        Topic topic = new TopicBuilder("super", message).ToUser(user).WithImportanceLevel(10).Build();

        // Act
        topic.SendMessage();
        user.DidNotReceive().AcceptThMessage(message);
    }

    [Fact]
    public void WithLog()
    {
        // Arrange
        var message = new Message(new Header("kaka"), new MessageBody("cool kaka"), 5);
        IUser user = new User();
        ILogger logger = Substitute.For<ILogger>();
        Topic topic = new TopicBuilder("super", message).ToUser(user).WithLogger(logger).Build();

        // Act
        topic.SendMessage();
        logger.Received().GoodLog("kaka");
    }

    [Fact]
    public void GoodMessenger()
    {
        // Arrange
        var message = new Message(new Header("kaka"), new MessageBody("cool kaka"), 5);
        ICoolMessenger coolMessenger = Substitute.For<ICoolMessenger>();
        IMessenger messenger = new СoolMessengerAdapter(coolMessenger);
        Topic topic = new TopicBuilder("super", message).ToMessenger(messenger).WithImportanceLevel(3).Build();

        // Act
        topic.SendMessage();
        coolMessenger.Received().AcceptThMessage(message);
    }
}