// recursion is a function that calls itself
// recursion is a way of solving problems by breaking them down into smaller problems of the same type
// recursion is a way of defining functions in which the function being defined is applied within its own definition


// Advantage - Using recursion, our code looks clean and more readable.
// 
// Disadvantages - When a recursive call is made, new storage locations for variables are 
// allocated on the stack. As each recursive call returns, the old variables and parameters 
// are removed from the stack. Hence, recursion generally uses more memory and is generally slow.

namespace functional_programming;

public static class Recursion
{

    // factorial of n (n!) = 1 * 2 * 3 * 4....n
    // 5! = 1 * 2 * 3 * 4 * 5 = 120

    public static Func<int, int> Factorial = n => n == 0 ? 1 : n * Factorial(n - 1);
    public static int Factorial2(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        return n * Factorial2(n - 1);
    }

    // sum number x to y
    public static Func<int, int, int> Sum = (x, y) => x == y ? x : x + Sum(x + 1, y);

    // fibonacci sequence
    // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34
    public static Func<int, int> Fibonacci = n => n <= 1 ? n : Fibonacci(n - 1) + Fibonacci(n - 2);

    // fibonacci sequence output list
    public static Func<int, List<int>> FibonacciList = n => n <= 1 ? new List<int> { n } : FibonacciList(n - 1).Append(Fibonacci(n)).ToList();

    // power of a number
    // 2^3 = 2 * 2 * 2 = 8
    public static Func<int, int, int> Power = (x, y) => y == 0 ? 1 : x * Power(x, y - 1);

    // count didigts of a number
    // 1234 = 4
    public static Func<int, int> CountDigits = n => n == 0 ? 0 : 1 + CountDigits(n / 10);

    // sum digits of a number
    // 1234 = 10
    public static Func<int, int> SumDigits = n => n == 0 ? 0 : n % 10 + SumDigits(n / 10);
}