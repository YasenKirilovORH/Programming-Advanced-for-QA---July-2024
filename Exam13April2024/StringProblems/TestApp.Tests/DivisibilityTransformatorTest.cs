using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class DivisibilityTransformatorTest
{
    [Test]
    public void Test_Transform_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;
        string expected = string.Empty;

        // Act
        string actual = DivisibilityTransformator.Transform(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Transform_InvalidValues_ReturnsEmptyString()
    {
        // Arrange
        string input = "one two three";
        string expected = string.Empty;

        // Act
        string actual = DivisibilityTransformator.Transform(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

        [Test]
    public void Test_Transform_ValidValues_ReturnsTransformedValues()
    {
        // Arrange
        string input = "12 15 8";
        string expected = "2 7.5 64";

        // Act
        string actual = DivisibilityTransformator.Transform(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Transform_ZeroOrNotDivisibleValues_ReturnsSameValues()
    {
        // Arrange
        string input = "7 23 0";
        string expected = "7 23 0";

        // Act
        string actual = DivisibilityTransformator.Transform(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}

