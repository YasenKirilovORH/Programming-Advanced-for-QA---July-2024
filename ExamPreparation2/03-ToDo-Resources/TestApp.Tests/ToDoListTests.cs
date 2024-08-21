using System;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using TestApp.Todo;

namespace TestApp.Tests;

[TestFixture]
public class ToDoListTests
{
    private ToDoList _toDoList = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._toDoList = new();
    }
    
    [Test]
    public void Test_AddTask_TaskAddedToToDoList()
    {
        // Arrange
        string title = "New task";
        DateTime dateTime = new DateTime(2024, 08, 29);

        string expected = $"To-Do List:" + Environment.NewLine +
                          $"[ ] {title} - Due: {dateTime.ToString("MM/dd/yyyy")}";
        _toDoList.AddTask(title, dateTime);

        // Act
        string actual = _toDoList.DisplayTasks();

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
    [Test]
    public void Test_CompleteTask_TaskMarkedAsCompleted()
    {
        // Arrange
        string title = "Completed Task";
        DateTime dateTime = new DateTime(2024, 05, 25);
        string checkmark = "\u2713";
        _toDoList.AddTask(title, dateTime);
        _toDoList.CompleteTask(title);

        string expected = $"To-Do List:" + Environment.NewLine +
                          $"[{checkmark}] {title} - Due: {dateTime.ToString("MM/dd/yyyy")}";

        // Act
        string actual = _toDoList.DisplayTasks();

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CompleteTask_TaskNotFound_ThrowsArgumentException()
    {
        // Arrange
        string title = "New task";
        DateTime dateTime = new DateTime(2024, 05, 25);

        // Act

        // Act Assert
        _toDoList.AddTask(title, dateTime);
        Assert.Throws<ArgumentException>(() => _toDoList.CompleteTask("Non Existing Task"));
    }

    [Test]
    public void Test_DisplayTasks_NoTasks_ReturnsEmptyString()
    {
        // Arrange
        string expected = "To-Do List:";

        // Act
        string actual = _toDoList.DisplayTasks();

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayTasks_WithTasks_ReturnsFormattedToDoList()
    {
        // Arrange
        string title = "First Task";
        DateTime dateTime = new DateTime(2024, 10, 12);
        string title2 = "Second Task";
        DateTime dateTime2 = new DateTime(2024, 05, 10);
        string checkmark = "\u2713";

        _toDoList.AddTask(title, dateTime);
        _toDoList.AddTask(title2, dateTime2);
        _toDoList.CompleteTask("Second Task");
        

        string expected = $"To-Do List:" + Environment.NewLine +
                          $"[ ] {title} - Due: {dateTime.ToString("MM/dd/yyyy")}" + Environment.NewLine +
                          $"[{checkmark}] {title2} - Due: {dateTime2.ToString("MM/dd/yyyy")}";

        // Act
        string actual = _toDoList.DisplayTasks();

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
