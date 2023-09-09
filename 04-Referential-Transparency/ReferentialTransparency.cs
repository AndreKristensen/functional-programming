// Referential transparency is a concept in functional programming where a function's output is solely 
// determined by its input, and it has no side effects. In other words, if you call a referentially 
// transparent function with the same arguments multiple times, it will always return the same result.
// This property makes code easier to reason about and test.

// In C#, achieving referential transparency can be challenging because C# is primarily an imperative, 
// object-oriented language, but you can still write functions that exhibit this property by following functional 
// programming principles. 

// immuatability

// pure functions

// avoid side effects  I/O, database, network, logging, accessing global state, and so on.

// pefere immutable collections over mutable ones System.Collections.Immutable

// avoiding nulls, use the null coalescing operator (??) or the null conditional operator (?.) to avoid null reference exceptions. 