
// In functional programming, a monad is a design pattern or a mathematical 
// concept that provides a way to structure computations and handle side effects in a 
// purely functional and composable manner. Monads are commonly used to address issues 
// related to impurity, such as I/O operations, state management, and exceptions, while 
// maintaining the principles of functional programming, such as immutability and referential transparency.


// boxes are monads
// a box is a container that can hold a value of any type
// a box can be empty or it can hold a value (maybe)

// Maybe<T> is a monad

namespace functional_programming;

public static class Monads
{

    public static string FarneheitToCelsius(decimal farenheit) =>
        farenheit.ToIdentity()
            .Bind(f => f - 32M)
            .Bind(f => f * 5M)
            .Bind(f => f / 9M)
            .Bind(f => Math.Round(f, 2))
            .Bind(f => $"{f}°C");

    public static string FindRickAndMortyCharacter(int id) => id.ToMaybe()
        .Bind(Exampels.FetchCharachtersById)
        .Bind(name => $"{name} is a Rick and Morty character");
}