using NUnit.Framework;
using System.Collections.Generic;
using functional_programming;

[TestFixture]
public class ImperativeExampleTests
{
    [Test]
    public void FindOldestImperative_ReturnsZeroForEmptyList()
    {
        // Arrange
        List<ExamplePerson> people = new ();

        // Act
        int result = ImperativeExample.FindOldestImperative(people);

        // Assert
        Assert.AreEqual(-1, result);
    }

    [Test]
    public void FindOldestImperative_ReturnsOldestAgeForNonEmptyList()
    {
        // Arrange
        List<ExamplePerson> people = new()
        {
            new ("Alice", 25),
            new ("Bob", 30),
            new ("Charlie", 20)
        };

        // Act
        int result = ImperativeExample.FindOldestImperative(people);

        // Assert
        Assert.AreEqual(30, result);
    }

    [Test]
    public void FindOldestFunctional_ReturnsZeroForEmptyList()
    {
        // Arrange
        List<ExamplePerson> people = new ();

        // Act
        int result = ImperativeExample.FindOldestFunctional(people);

        // Assert
        Assert.AreEqual(-1, result);
    }

    [Test]
    public void FindOldestFunctional_ReturnsOldestAgeForNonEmptyList()
    {
        // Arrange
        List<ExamplePerson> people = new()
        {
            new ("Alice", 25),
            new ("Bob", 30),
            new ("Charlie", 20)
        };

        // Act
        int result = ImperativeExample.FindOldestFunctional(people);

        // Assert
        Assert.AreEqual(30, result);
    }
}