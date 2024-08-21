using System;
using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class GradesTests
{
    [Test]
    public void Test_GetBestStudents_ReturnsBestThreeStudents()
    {
        // Arrange
        Dictionary<string, int> grades = new Dictionary<string, int>()
        {
            { "Ivan", 3 },
            { "Sonya", 6 },
            { "Michael", 4 },
            { "George", 3 },
            { "Petya", 5 },
            { "Stoil", 2 }
        };
        string expected = $"Sonya with average grade 6.00" + Environment.NewLine +
                          $"Petya with average grade 5.00" + Environment.NewLine +
                          $"Michael with average grade 4.00";

        // Act
        string actual = Grades.GetBestStudents(grades);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetBestStudents_EmptyGrades_ReturnsEmptyString()
    {
        // Arrange
        Dictionary<string, int> grades = new Dictionary<string, int>();
        string expected = string.Empty;

        // Act
        string actual = Grades.GetBestStudents(grades);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetBestStudents_LessThanThreeStudents_ReturnsAllStudents()
    {
        // Arrange
        Dictionary<string, int> grades = new Dictionary<string, int>()
        {
            { "George", 3 },
            { "Petya", 5 }
        };
        string expected = $"Petya with average grade 5.00" + Environment.NewLine +
                          $"George with average grade 3.00";

        // Act
        string actual = Grades.GetBestStudents(grades);

        // Assert
        Assert.That (actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GetBestStudents_SameGrade_ReturnsInAlphabeticalOrder()
    {
        // Arrange
        Dictionary<string, int> grades = new Dictionary<string, int>()
        {
            { "Ivan", 6 },
            { "Atanas", 6 },
            { "Michael", 6 },
            { "George", 6 },
            { "Stoil", 6 }
        };
        string expected = $"Atanas with average grade 6.00" + Environment.NewLine +
                          $"George with average grade 6.00" + Environment.NewLine +
                          $"Ivan with average grade 6.00";

        // Act
        string actual = Grades.GetBestStudents(grades);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
