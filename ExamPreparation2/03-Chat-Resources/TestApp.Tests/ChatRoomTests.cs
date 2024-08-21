using System;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using System.Reflection;
using NUnit.Framework;
using TestApp.Chat;
using NUnit.Framework.Constraints;
namespace TestApp.Tests;

[TestFixture]
public class ChatRoomTests
{
    private ChatRoom _chatRoom = null!;
    
    [SetUp]
    public void Setup()
    {
        this._chatRoom = new();
    }
    
    [Test]
    public void Test_SendMessage_MessageSentToChatRoom()
    {
        // Arrange
        string sender = "Yasen";
        string message = "Hello";
        string expectedDate = DateTime.Now.ToString("d");
       
        _chatRoom.SendMessage(sender, message);
        string expected = "Chat Room Messages:" + Environment.NewLine +
                          $"{sender}: {message} - Sent at {expectedDate}";

        // Act
        string actual = _chatRoom.DisplayChat();

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayChat_NoMessages_ReturnsEmptyString()
    {
        // Arrange
        string expected = string.Empty;

        // Act
        string actual = _chatRoom.DisplayChat();

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayChat_WithMessages_ReturnsFormattedChat()
    {
        // Arrange
        _chatRoom.SendMessage("Yasen", "Hello");
        _chatRoom.SendMessage("Peter", "Hi");
        _chatRoom.SendMessage("Tom", "Hi guys");
        string expectedDate = DateTime.Now.ToString("d");

        string expected = "Chat Room Messages:" + Environment.NewLine +
                           $"Yasen: Hello - Sent at {expectedDate}" + Environment.NewLine +
                           $"Peter: Hi - Sent at {expectedDate}" + Environment.NewLine +
                           $"Tom: Hi guys - Sent at {expectedDate}";

        // Act
        string actual = _chatRoom.DisplayChat();

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
