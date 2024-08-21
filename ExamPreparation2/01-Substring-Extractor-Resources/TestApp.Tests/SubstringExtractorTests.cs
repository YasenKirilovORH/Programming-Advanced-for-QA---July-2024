using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class SubstringExtractorTests
{
    [Test]
    public void Test_ExtractSubstringBetweenMarkers_SubstringFound_ReturnsExtractedSubstring()
    {
        // Arrange
        string input = "abcdefgh";
        string startMarker = "b";
        string endMarker = "e";
        string expected = "cd";

        // Act
        string actual = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartMarkerNotFound_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "defcaqw";
        string startMarker = "b";
        string endMarker = "q";
        string expected = "Substring not found";

        // Act
        string actual = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_EndMarkerNotFound_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "defcaqw";
        string startMarker = "f";
        string endMarker = "z";
        string expected = "Substring not found";

        // Act
        string actual = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersNotFound_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "hello";
        string startMarker = "a";
        string endMarker = "b";
        string expected = "Substring not found";

        // Act
        string actual = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_EmptyInput_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "";
        string startMarker = "a";
        string endMarker = "b";
        string expected = "Substring not found";

        // Act
        string actual = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersOverlapping_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "hello";
        string startMarker = "e";
        string endMarker = "e";
        string expected = "Substring not found";

        // Act
        string actual = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
