using functional_programming;
using NUnit.Framework;

[TestFixture]
public class ValidateTests
{
    [Test]
    public void IsEmpty_ReturnsTrueForEmptyList()
    {
        // Arrange
        List<int> input = new List<int>();

        // Act
        bool result = input.IsEmpty();

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void IsEmpty_ReturnsFalseForNonEmptyList()
    {
        // Arrange
        List<int> input = new List<int> { 1, 2, 3 };

        // Act
        bool result = input.IsEmpty();

        // Assert
        Assert.IsFalse(result);
    }
    [Test]
    public void IsEmpty_ReturnsTrueForNullList()
    {
        // Arrange
        List<int> input = null;

        // Act
        bool result = input.IsEmpty();

        // Assert
        Assert.IsTrue(result);
    }
}