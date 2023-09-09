// Immutability is a design principle that states that the state of an object cannot be altered after the object has been created.

namespace functional_programming
{

    public class Person
    {
        public Guid Id { get; init; } = Guid.NewGuid();

        public string FirstName { get; }
        public string LastName { get; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }

    public class PersonReadOnly
    {
        public readonly Guid Id;
        public readonly string FirstName;
        public readonly string LastName;

        public PersonReadOnly(string firstName, string lastName)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
        }
    }
    record PersonRecord
    {
        public Guid Id { get; init; } = Guid.NewGuid();
        public string? FirstName { get; init; }
        public string? LastName { get; init; }
    }

}
