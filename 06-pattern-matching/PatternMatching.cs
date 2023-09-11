// Pattern matching is a mechanism for checking a value against a pattern and, 
// based on the match, performing some kind of action. 
// It is a fundamental feature of many programming languages
// C# 7.0 introduces basic pattern matching in is expression and switch statement, 
// including constant value as pattern and type as pattern, and C# 7.1 supports generics in pattern matching.

namespace functional_programming;

record Rectangle(int Length, int Height);
record Circle(int Radius);
record Square(int Length);
record Triangle(int Length, int Height);


public static class Shapes
{
    // constant pattern
    public static Func<object, bool> IsShapeNull = (shape) => shape is null;
 
    // Declaration pattern
    public static Func<object, bool> IsShapeSquare = (shape) => shape is Square;

    // Property pattern;
    public static Func<object, bool> IsSpecificTriangle = (shape) => shape is Triangle { Length: 10, Height: 20 };

    //var pattern IsLengthMultipleOfThree
    public static Func<object, bool> IsLengthMultipleOfThree = (shape) => shape is Rectangle { Length: var length } && length % 3 == 0;

    // Tuple pattern
    public static Func<object,int,int, string> ReturnDescriptionOfShape = (shape, length, height) => (shape, length, height) switch
    {
        (Rectangle, 2, 1) => "This is a small rectangle",
        (Triangle, 20, 10) => "This is a big triangle",
        (Square, 10, _) => "Square with length 10",
        (_,_,_) => "Unknown"
    };

    // Relational pattern
    public static Func<object, string> ReturnDescriptionOfShapeWithRelationalPattern = (shape) => shape switch
    {
        Rectangle { Length: < 10 } => "This is a small rectangle",
        Triangle { Height: > 10 } => "This is a big triangle",
        Square { Length: 10 } => "Square with length 10",
        _ => "Unknown"
    };

    // switch 
    public static Func<object, double> CalculateArea = (shape) => shape switch
    {
        Rectangle { Length: var length, Height: var height } => length * height,
        Circle { Radius: var radius } => Math.PI * radius * radius,
        Square { Length: var length } => length * length,
        Triangle { Length: var length, Height: var height } => length * height / 2,
        _ => throw new ArgumentException(message: "invalid shape", paramName: nameof(shape))
    };
  
}


