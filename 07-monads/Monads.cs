
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
    public static string FahrenheitToCelsius(decimal fahrenheit) =>
        fahrenheit.ToIdentity()
            .Bind(f => f - 32M)
            .Bind(f => f * 5M)
            .Bind(f => f / 9M)
            .Bind(f => Math.Round(f, 2))
            .Bind(f => $"{f}°C");

    public static Func<Character, Character> NameToUpperCase = (x) => throw new NotImplementedException();

    public static string FindRickAndMortyCharacter(int id) => id.ToMaybe()
        .Bind(Examples.FetchCharactersById)
        // .Bind(NameToUpperCase)
        .Bind(character => $"{character.Name} is a Rick and Morty character");

    public static string CelsiusToFahrenheit(decimal celsius) =>
        celsius.ToMaybe()
        .Bind(c => c * 9M)
        .Bind(c => c / 5M)
        .Bind(c => c + 32M)
        .Bind(Math.Floor)
        .Bind(c => $"{c}°F");
}