namespace functional_programming;

// I trust you, it will work
// In C#, operators are symbols or keywords used to perform operations on variables or values.
// Implicit and explicit operators are two types of operators used to convert a variable or value from one type to another. 
// this is a box with a thing inside it T is a generic. It can be anything int string etc 


public class Identity<T>(T value)
{
    public T Value { get; } = value;

    public static implicit operator Identity<T>(T @this) => @this.ToIdentity();

    public static implicit operator T(Identity<T> @this) => @this.Value;

}