using FluentAssertions;
using functional_programming;
using NUnit.Framework;

[TestFixture]
public class PureFunctionsTests
{
    [Test]
    public void Add_ReturnsCorrectResult()
    {
        // Arrange
        int x = 5;
        int y = 10;

        // Act
        int result = PureFunctions.Add(x, y);

        // Assert
        result.Should().Be(15);
    }

    [Test]
    public void Multiply_ReturnsCorrectResult()
    {
        // Arrange
        int x = 5;
        int y = 10;

        // Act
        int result = PureFunctions.Multiply(x, y);

        // Assert
        result.Should().Be(50);
    }

    [Test]
    public void Subtract_ReturnsCorrectResult()
    {
        // Arrange
        int x = 10;
        int y = 5;

        // Act
        int result = PureFunctions.Subtract(x, y);

        // Assert
        result.Should().Be(5);
    }

    [Test]
    public void Divide_ReturnsCorrectResult()
    {
        // Arrange
        int x = 10;
        int y = 5;

        // Act
        int result = PureFunctions.Divide(x, y);

        // Assert
        result.Should().Be(2);
    }
}