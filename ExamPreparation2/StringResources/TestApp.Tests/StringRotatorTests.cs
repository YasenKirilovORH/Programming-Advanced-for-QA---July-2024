using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringRotatorTests
{
    [Test]
    public void Test_RotateRight_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;
        int possitions = 2;
        string expected = string.Empty;
        
        // Act
        string actual = StringRotator.RotateRight(input, possitions);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByZeroPositions_ReturnsOriginalString()
    {
        // Arrange
        string input = "name";
        int possitions = 0;
        string expected = "name";

        // Act
        string actual = StringRotator.RotateRight(input, possitions);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByPositivePositions_ReturnsRotatedString()
    {
        // Arrange
        string input = "rotation";
        int possitions = 4;
        string expected = "tionrota";

        // Act
        string actual = StringRotator.RotateRight(input, possitions);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByNegativePositions_ReturnsRotatedString()
    {
        // Arrange
        string input = "hello";
        int possitions = -2;
        string expected = "lohel";

        // Act
        string actual = StringRotator.RotateRight(input, possitions);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByMorePositionsThanStringLength_ReturnsRotatedString()
    {
        // Arrange
        string input = "dog";
        int possitions = 5;
        string expected = "ogd";

        // Act
        string actual = StringRotator.RotateRight(input, possitions);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
