using NUnit.Framework;
using functional_programming;

[TestFixture]
public class FirstClassAndHigherOrderFunctionsTests
{
    [Test]
    public void Greet_ReturnsCorrectGreeting()
    {
        // Arrange
        string name = "John";

        // Act
        string result = FirsClassAndHigherOrderFunctions.Greet(name);

        // Assert
        Assert.AreEqual($"Hello {name}!", result);
    }

    [Test]
    public void PerformOperation_Addition_ReturnsCorrectResult()
    {
        // Arrange
        int a = 5;
        int b = 10;

        // Act
        int result = FirsClassAndHigherOrderFunctions.PerformOperation((x, y) => x + y, a, b);

        // Assert
        Assert.AreEqual(15, result);
    }

    [Test]
    public void PerformOperation_Multiplication_ReturnsCorrectResult()
    {
        // Arrange
        int a = 5;
        int b = 10;

        // Act
        int result = FirsClassAndHigherOrderFunctions.PerformOperation((x, y) => x * y, a, b);

        // Assert
        Assert.AreEqual(50, result);
    }

    [Test]
    public void CreateMultiplier_ReturnsCorrectMultiplier()
    {
        // Arrange
        int factor = 5;

        // Act
        Func<int, int> multiplier = FirsClassAndHigherOrderFunctions.CreateMultiplier(factor);

        // Assert
        Assert.AreEqual(10, multiplier(2));
        Assert.AreEqual(15, multiplier(3));
    }

    [Test]
    public void IsOdd_ReturnsTrueForOddNumbers()
    {
        // Arrange
        int oddNumber = 5;
        int evenNumber = 6;

        // Act
        bool oddResult = FirsClassAndHigherOrderFunctions.IsOdd(oddNumber);
        bool evenResult = FirsClassAndHigherOrderFunctions.IsOdd(evenNumber);

        // Assert
        Assert.IsTrue(oddResult);
        Assert.IsFalse(evenResult);
    }

    [Test]
    public void GetOddNumbers_ReturnsOddNumbers()
    {
        // Arrange
        List<int> numbers = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        // Where is a good example of higher-order function.
        // Act
        List<int> result = numbers.Where(FirsClassAndHigherOrderFunctions.IsOdd).ToList();


        // Assert
        Assert.IsTrue(result is [1, 3, 5, 7, 9]);
    }

    [Test]
    public void test()
    {
        string result = FirsClassAndHigherOrderFunctions.Greet("Test");

    }

    [Test]
    public void Divide_ReturnsCorrectResult()
    {
        // Arrange
        int a = 10;
        int b = 5;

        // Act
        int result = FirsClassAndHigherOrderFunctions.Divide(a, b);

        // Assert
        Assert.AreEqual(2, result);
    }

    [Test]
    public void Divide_ByZeroThrowsDivideByZeroException()
    {
        // Arrange
        int a = 10;
        int b = 0;

        // Act and Assert
        Assert.Throws<DivideByZeroException>(() => FirsClassAndHigherOrderFunctions.Divide(a, b));
    }

    [Test]
    public void Swap_SwapsValues()
    {
        // Arrange
        int a = 2;
        int b = 6;

        // Act
        var divideBy = FirsClassAndHigherOrderFunctions.Divide.Swap();

        var result = divideBy(a, b);

        // Assert
        Assert.AreEqual(result, 3);
    }

    [Test]
    public void Test_Functions_in_datastructures()
    {
        // Arrange

        Assert.AreEqual(FirsClassAndHigherOrderFunctions.MathOperations["add"](5, 3), 8);
        Assert.AreEqual(FirsClassAndHigherOrderFunctions.MathOperations["subtract"](5, 3), 2);
    }
}