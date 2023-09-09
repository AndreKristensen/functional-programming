// first-class functions — a programming language is said to have first-class functions when functions can be treated as any other data. 
// In C# first-class functions are supported using anonymous methods and lambdas. 
// Delegates

// Higher order function is a function that takes one or more functions as arguments, 
// or returns a function, or both. We are used to passing as function parameters simple objects 
// like integers or strings, or more complex objects like collections and custom types. 
// But C# also has good support for HOFs.  This is done using delegates and lambda expressions.

namespace functional_programming;
public static class FirsClassAndHigherOrderFunctions
{
    public static Func<string, string> Greet = name => $"Hello {name}!";

    public static Func<int, bool> IsOdd = x => x % 2 != 0;

    public static Func<int, int, int> Add = (x, y) => x + y;
    public static Func<int, int, int> Subtract = (x, y) => x - y;
    public static Func<int, int, int> Divide = (x, y) => x / y;

    public static int PerformOperation(Func<int, int, int> operation, int a, int b) => operation(a, b);

    public static Func<int, Func<int, int>> CreateMultiplier = (factor) => (x) => x * factor;

    public static Func<T2, T1, R> Swap<T1, T2, R>(this Func<T1, T2, R> func)
    => (t2, t1) => func(t1, t2);


    public static Dictionary<string, Func<int, int, int>> MathOperations = new()
    {
            { "add", Add },
            { "subtract", Subtract },
            { "divide", Divide }
        };
}

