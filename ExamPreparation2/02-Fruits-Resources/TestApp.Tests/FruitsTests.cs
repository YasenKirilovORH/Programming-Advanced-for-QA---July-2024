using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class FruitsTests
{
    [Test]
    public void Test_GetFruitQuantity_FruitExists_ReturnsQuantity()
    {
        // Arrange
        Dictionary<string, int> fruitsDictionary = new Dictionary<string, int>()
        {
            { "apple", 5 },
            { "kiwi", 10 },
            { "orange", 3 }
        };
        string fruitToSearchFor = "kiwi";
        int expectedQuantity = 10;

        // Act
        int actualQuantity = Fruits.GetFruitQuantity(fruitsDictionary, fruitToSearchFor);

        // Assert
        Assert.That(actualQuantity, Is.EqualTo(expectedQuantity));
    }

    [Test]
    public void Test_GetFruitQuantity_FruitDoesNotExist_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> fruitsDictionary = new Dictionary<string, int>()
        {
            { "lemon", 12 },
            { "dragonFruit", 1 },
            { "peach", 7 }
        };
        string fruitToSearchFor = "mango";
        int expectedQuantity = 0;

        // Act
        int actualQuantity = Fruits.GetFruitQuantity(fruitsDictionary, fruitToSearchFor);

        // Assert
        Assert.That(actualQuantity, Is.EqualTo(expectedQuantity));
    }

    [Test]
    public void Test_GetFruitQuantity_EmptyDictionary_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> fruitsDictionary = new Dictionary<string, int>();
        string fruitToSearchFor = "apple";
        int expectedQuantity = 0;

        int actualQuantity = Fruits.GetFruitQuantity(fruitsDictionary, fruitToSearchFor);

        // Assert
        Assert.That(actualQuantity, Is.EqualTo(expectedQuantity));
    }

    [Test]
    public void Test_GetFruitQuantity_NullDictionary_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> fruitsDictionary = null;
        string fruitToSearchFor = "orange";
        int expectedQuantity = 0;

        int actualQuantity = Fruits.GetFruitQuantity(fruitsDictionary, fruitToSearchFor);

        // Assert
        Assert.That(actualQuantity, Is.EqualTo(expectedQuantity));
    }

    [Test]
    public void Test_GetFruitQuantity_NullFruitName_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> fruitsDictionary = new Dictionary<string, int>()
        {
            { "kiwi", 15 },
            { "mango", 6 },
            { "apple", 7 }
        };
        string fruitToSearchFor = null;
        int expectedQuantity = 0;

        int actualQuantity = Fruits.GetFruitQuantity(fruitsDictionary, fruitToSearchFor);

        // Assert
        Assert.That(actualQuantity, Is.EqualTo(expectedQuantity));
    }
}
