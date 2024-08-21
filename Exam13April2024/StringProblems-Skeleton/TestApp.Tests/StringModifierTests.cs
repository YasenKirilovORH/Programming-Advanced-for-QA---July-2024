using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringModifierTests
{
    [Test]
    public void Test_Modify_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;
        string expected = string.Empty;

        // Act
        string actual = StringModifier.Modify(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Modify_SingleWordWithEvenLength_ReturnsUppperCaseWord()
    {
        // Arrange
        string input = "word";
        string expected = "WORD";

        // Act
        string actual = StringModifier.Modify(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Modify_SingleWordWithOddLength_ReturnsToLowerCaseWord()
    {
        string input = "Words";
        string expected = "words";

        // Act
        string actual = StringModifier.Modify(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Modify_MultipleWords_ReturnsModifiedString()
    {
        string input = "Software testing for this exam";
        string expected = "SOFTWARE testing for THIS EXAM";

        // Act
        string actual = StringModifier.Modify(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}

