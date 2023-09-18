using NUnit.Framework;
using functional_programming;

[TestFixture]
public class RecursionTests
{
    [Test]
    public void Factorial_ReturnsCorrectResult()
    {
        // Arrange
        int n = 5;

        // Act
        int result = Recursion.Factorial(n);

        // Assert
        Assert.AreEqual(120, result);
    }
    [Test]
    public void Factorial2_ReturnsCorrectResult()
    {
        // Arrange
        int n = 5;

        // Act
        int result = Recursion.Factorial2(n);

        // Assert
        Assert.AreEqual(120, result);
    }

    [Test]
    public void Sum_ReturnsCorrectResult()
    {
        // Arrange
        int x = 1;
        int y = 5;

        // Act
        int result = Recursion.Sum(x, y);

        // Assert
        Assert.AreEqual(15, result);
    }

    [Test]
    public void Power_ReturnsCorrectResult()
    {
        // Arrange
        int x = 2;
        int y = 3;

        // Act
        int result = Recursion.Power(x, y);

        // Assert
        Assert.AreEqual(8, result);
    }

    [Test]
    public void CountDigits_ReturnsCorrectResult()
    {
        // Arrange
        int n = 1234;

        // Act
        int result = Recursion.CountDigits(n);

        // Assert
        Assert.AreEqual(4, result);
    }

    [Test]
    public void SumDigits_ReturnsCorrectResult()
    {
        // Arrange
        int n = 1234;

        // Act
        int result = Recursion.SumDigits(n);

        // Assert
        Assert.AreEqual(10, result);
    }
}