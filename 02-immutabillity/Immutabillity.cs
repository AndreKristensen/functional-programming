// Immutability is a design principle that states that the state of an object cannot be altered after the object has been created.
// immutable objects are thread-safe by definition and can be shared freely across threads.
// immutabilit faccilitates composistion 
// immutabel value passed trhou a pure function will always produce the same result
// deterministic code now emergent behavior.
namespace functional_programming
{

 public class PersonMutable
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public PersonMutable(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }

    public class PersonImmutable
    {
        public Guid Id { get; init; } = Guid.NewGuid();

        public string FirstName { get; }
        public string LastName { get; }

        public PersonImmutable(string firstName, string lastName)
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
