using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class DictionaryIntersectionTests
{
    [Test]
    public void Test_Intersect_TwoEmptyDictionaries_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>();
        Dictionary<string, int> dict2 = new Dictionary<string, int>();

        // Act
        Dictionary<string, int> actualIntersection = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.That(actualIntersection, Is.Empty);
    }

    [Test]
    public void Test_Intersect_OneEmptyDictionaryAndOneNonEmptyDictionary_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>()
        {
            { "two", 2 },
            { "seven", 7 }
        };

        Dictionary<string, int> dict2 = new Dictionary<string, int>();

        // Act
        Dictionary<string, int> actualIntersection = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.That(actualIntersection, Is.Empty);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithNoCommonKeys_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>()
        {
            { "six", 6 },
            { "five", 5 }
        };

        Dictionary<string, int> dict2 = new Dictionary<string, int>()
        {
            { "one", 1 },
            { "three", 3 }
        };

        // Act
        Dictionary<string, int> actualIntersection = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.That(actualIntersection, Is.Empty);
    }


    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndValues_ReturnsIntersectionDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>()
        {
            { "dog", 2 },
            { "cat", 5 },
            { "cow", 6 } 
        };

        Dictionary<string, int> dict2 = new Dictionary<string, int>()
        {
            { "dog", 2 },
            { "cat", 2 },
            { "cow", 6 }
        };

        Dictionary<string, int> expectedIntersection = new Dictionary<string, int>()
        {
            { "dog", 2 },
            { "cow", 6 }
        };

        // Act
        Dictionary<string, int> actualIntersection = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        CollectionAssert.AreEqual(expectedIntersection, actualIntersection);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndDifferentValues_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>()
        {
            { "dog", 4 },
            { "cat", 5 },
            { "rat", 9 }
        };

        Dictionary<string, int> dict2 = new Dictionary<string, int>()
        {
            { "dog", 1 },
            { "cat", 8 },
            { "rat", 2 }
        };

        // Act
        Dictionary<string, int> actualIntersection = DictionaryIntersection.Intersect(dict1, dict2);

        // Assert
        Assert.That(actualIntersection, Is.Empty);

    }
}
