using NUnit.Framework;
using System;

namespace TestApp.Tests;

[TestFixture]
public class CsvParserTests
{
    [Test]
    public void Test_ParseCsv_EmptyInput_ReturnsEmptyArray()
    {
        // Arrange
        string input = string.Empty;
        string[] expected = Array.Empty<string>();

        // Act
        string[] actual = CsvParser.ParseCsv(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseCsv_SingleField_ReturnsArrayWithOneElement()
    {
        // Arrange
        string input = "word";
        string[] expected = { "word" };

        // Act
        string[] actual = CsvParser.ParseCsv(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseCsv_MultipleFields_ReturnsArrayWithMultipleElements()
    {
        // Arrange
        string input = "Unit,testing,exam";
        string[] expected = { "Unit", "testing", "exam" };

        string[] actual = CsvParser.ParseCsv(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseCsv_TrimsWhiteSpace_ReturnsCleanArray()
    {
        // Arrange
        string input = "Unit,testing,         exam         ";
        string[] expected = { "Unit", "testing", "exam" };

        string[] actual = CsvParser.ParseCsv(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
