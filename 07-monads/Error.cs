namespace functional_programming;
public class Error<T>(Exception exception) : Maybe<T>
{
    public override T Value => default;

    public Exception Exception { get; init; } = exception;
}