
using functional_programming;

public static class IdentityExtensions
{
  // Put a thing in the box
  public static Identity<T> ToIdentity<T>(this T @this) => new(@this);

  // bind is a function that takes a function and returns a function
  // take my old box take the value out, run it through the function and put it in a new box
  public static Identity<TToType> Bind<TFromType, TToType>(this Identity<TFromType> @this, Func<TFromType, TToType> func) => func(@this.Value).ToIdentity();

  public static Maybe<T> ToMaybe<T>(this T vaule) => new Just<T>(vaule);

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
        return new Error<TToType>(e);
      }
    }
    else
    {
      return new Nothing<TToType>();
    }
  }
  // thing in a box, take the thing out of the box, run it through the function and put it in a new maybe box
  //   public static Maybe<TToType> Bind<TFromType, TToType>(this Maybe<TFromType> @this, Func<TFromType, TToType> func) => @this switch
  //   {
  //     Just<TFromType> just  something when!EqualityComparer<TFromType>.Default.Equals(something.Value, default)   {
  //         try{
  //            reutrn func(something).ToMaybe();
  //         }catch(Exception ) {
  //             return new Nothing<TToType>();
  //         }

  //    } _ => new Nothing<TToType>()
  // };
}