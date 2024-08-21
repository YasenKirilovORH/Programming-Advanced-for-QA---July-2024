using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class WordLengthAnalyzerTests
{
    [Test]
    public void Test_AnalyzeSentence_EmptyString_ReturnsEmptyDictionary()
    {
        // Arrange
        string input = string.Empty;
        Dictionary<string, int> expected = new Dictionary<string, int>();

        // Act
        Dictionary<string, int> actual = WordLengthAnalyzer.AnalyzeSentence(input);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_AnalyzeSentence_InvalidWordsWithDigits_ReturnsEmptyDictionary()
    {
        // Arrange
        string input = "On3 2 D1g1ts";
        Dictionary<string, int> expected = new Dictionary<string, int>();

        Dictionary<string, int> actual = WordLengthAnalyzer.AnalyzeSentence(input);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_AnalyzeSentence_WordsWithDifferentThanLetterSymbols_ReturnsDictionaryOnlyWithValidWordTypesCount()
    {
        // Arrange
        string input = "Valid Inval1d w0rds";
        Dictionary<string, int> expected = new Dictionary<string, int>()
        {
            { "medium", 1 }
        };

        Dictionary<string, int> actual = WordLengthAnalyzer.AnalyzeSentence(input);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_AnalyzeSentence_WholeSentenceWithValidWords_ReturnsAllTypeOfWordsWithCorrectCount()
    {
        // Arrange
        string input = "Quality assurance courses of SoftUni are the best!";
        Dictionary<string, int> expected = new Dictionary<string, int>() 
        {
            { "short", 4 },
            { "medium", 3 },
            { "long", 1 }
        };

        // Act
        Dictionary<string, int> actual = WordLengthAnalyzer.AnalyzeSentence(input);

        // Assert
        CollectionAssert.AreEqual(actual, expected);
    }
}

