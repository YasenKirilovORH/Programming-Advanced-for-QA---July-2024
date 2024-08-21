using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class SentenceAnalyzerTests
{
    [Test]
    public void Test_Analyze_EmptyString_ReturnsEmptyDictionary()
    {
        // Arrange
        string input = string.Empty;
        Dictionary<string, int> expected = new Dictionary<string, int>();

        // Act
        Dictionary<string, int> actual = SentenceAnalyzer.Analyze(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Analyze_SingleLetter_ReturnsDictionaryWithSingleLetterEntry()
    {
        // Arrange
        string input = "R";
        Dictionary<string, int> expected = new Dictionary<string, int>()
        {
            { "letters", 1 }
        };

        // Act
        Dictionary<string, int> actual = SentenceAnalyzer.Analyze(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Analyze_SingleDigit_ReturnsDictionaryWithSingleDigitEntry()
    {
        // Arrange
        string input = "5";
        Dictionary<string, int> expected = new Dictionary<string, int>()
        {
            { "digits", 1 }
        };

        // Act
        Dictionary<string, int> actual = SentenceAnalyzer.Analyze(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Analyze_WholeSentence_ReturnsDictionaryWithAllSymbolTypesCount()
    {
        // Arrange
        string input = "Doing a test with symbols such as # and ! but also with some numbers like 22 or 4 or 1.";
        Dictionary<string, int> expected = new Dictionary<string, int>()
        {
            { "letters", 60 },
            { "digits", 4 },
            { "special characters", 3 }
        };

        // Act
        Dictionary<string, int> actual = SentenceAnalyzer.Analyze(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}

