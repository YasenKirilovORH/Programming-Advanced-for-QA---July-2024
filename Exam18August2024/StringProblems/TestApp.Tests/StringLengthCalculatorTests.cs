using System;
using System.Text;
using System.Linq;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestApp.Tests;

[TestFixture]
public class StringLengthCalculatorTests
{
    [Test]
    public void Test_Calculate_EmptyString_ReturnsZero()
    {
        // Arrange
        string input = String.Empty;
        double expected = 0;

        // Act
        double actual = StringLengthCalculator.Calculate(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Calculate_SingleEvenLengthWord_ReturnsCorrectInteger()
    {
        // Arrange
        string input = "test";
        double expected = 896;

        // Act
        double actual = StringLengthCalculator.Calculate(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test_Calculate_SingleOddLengthWord_ReturnsCorrectInteger()
    {
        // Arrange
        string input = "SoftUni";
        double expected = 356;

        // Act
        double actual = StringLengthCalculator.Calculate(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Calculate_WholeSentenceString_ReturnsCorrectInteger()
    {
        // Arrange
        string input = "SoftUni is the best!";
        double expected = 3624;

        // Act
        double actual = StringLengthCalculator.Calculate(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

}

