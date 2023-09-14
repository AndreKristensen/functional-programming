
namespace functional_programming;

// bind is a function that takes a Identity and runs a function and returns a Identity
// take my old box take the value out, run it through the function and put it in a new box

public static class MonadExtensions
{
  public static Identity<T> ToIdentity<T>(this T @this) => new(@this);

  public static Identity<TToType> Bind<TFromType, TToType>(this Identity<TFromType> @this, Func<TFromType, TToType> func) => func(@this.Value).ToIdentity();

  public static Maybe<T> ToMaybe<T>(this T @value) => new Just<T>(@value);

  public static Maybe<TToType> Bind<TFromType, TToType>(this Maybe<TFromType> @this, Func<TFromType, TToType> func)
  {
    if (@this is Just<TFromType> just && !EqualityComparer<TFromType>.Default.Equals(just.Value, default))
    {
      try
      {
        return func(just).ToMaybe();
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
        return new Error<TToType>(e);
      }
    }
    else
    {
      return new Nothing<TToType>();
    }
  }

}