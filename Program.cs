// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;
using functional_programming;

using Newtonsoft.Json;


Console.WriteLine(FirsClassAndHigherOrderFunctions.Greet("World"));



Console.WriteLine(FirsClassAndHigherOrderFunctions.PerformOperation(PureFunctions.Add, 5, 10));
// Output: 15
Console.WriteLine(FirsClassAndHigherOrderFunctions.PerformOperation(PureFunctions.Subtract, 5, 10));
// Output: -5
Console.WriteLine(FirsClassAndHigherOrderFunctions.PerformOperation((a, b) => a / b, 10, 5));
// Output: 2
Console.WriteLine(FirsClassAndHigherOrderFunctions.PerformOperation((a, b) => a * b, 10, 5));
// Output: 50

var doubleFunc = FirsClassAndHigherOrderFunctions.CreateMultiplier(2);

var tripleFunc = FirsClassAndHigherOrderFunctions.CreateMultiplier(3);


Console.WriteLine(doubleFunc(4));
// Output: 8
Console.WriteLine(tripleFunc(4));
// Output: 12










