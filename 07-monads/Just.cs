namespace functional_programming;
public class Just<T>(T value) : Maybe<T>
{
    public override T Value { get; } = value;
}