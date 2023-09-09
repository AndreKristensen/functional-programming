using NUnit.Framework;
using functional_programming;

[TestFixture]
public class ImmutabilityTests
{
    [Test]
    public void Person_ImmutableAfterConstruction()
    {
        // Arrange
        string firstName = "John";
        string lastName = "Doe";

        // Act
        Person person = new(firstName, lastName);

        // Assert
        Assert.AreEqual(firstName, person.FirstName);
        Assert.AreEqual(lastName, person.LastName);

        // Property or indexer 'Person.FirstName' cannot be assigned to -- it is read only
        // person.FirstName = "Jane";

    }

    [Test]
    public void PersonReadOnly_ImmutableAfterConstruction()
    {
        // Arrange
        string firstName = "John";
        string lastName = "Doe";

        // Act
        PersonReadOnly person = new PersonReadOnly(firstName, lastName);

        // Assert
        Assert.AreEqual(firstName, person.FirstName);
        Assert.AreEqual(lastName, person.LastName);

        // Attempt to modify the properties
        // A readonly field cannot be assigned to (except in a constructor or init-only setter of the type in which the field is defined or a variable initializer)
        //  person.FirstName = "Jane"
    }
    [Test]
    public void PersonRecord_ImmutableAfterConstruction()
    {
        // Arrange
        string firstName = "John";
        string lastName = "Doe";

        // Act
        PersonRecord person = new PersonRecord { FirstName = firstName, LastName = lastName };

        // Assert
        Assert.AreEqual(firstName, person.FirstName);
        Assert.AreEqual(lastName, person.LastName);

        // Attempt to modify the properties
        // Init-only property or indexer 'PersonRecord.FirstName' can only be assigned in an object initializer, or on 'this' or 'base' in an instance constructor or an 'init' accessor.Init-only property or indexer 'PersonRecord.FirstName' can only be assigned in an object initializer, or on 'this' or 'base' in an instance constructor or an 'init' accessor.
        //   person.FirstName person.FirstName = "Jane"= "Jane"

    }
}