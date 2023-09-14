namespace functional_programming;

// Schrödingers type maybe its a thing or nothing
public abstract class Maybe<T>
{
    public abstract T Value { get; }

    public static implicit operator T(Maybe<T> @this) => @this.Value;
}