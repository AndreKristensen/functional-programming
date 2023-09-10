
namespace functional_programming;
public static class Validate
{
    public static bool ValidatePassword(this string password, params Func<string, bool>[] predicates) => predicates.All(x => x(password));
    public static bool ValidateGeneric<TIn>(this TIn @input, params Func<TIn, bool>[] predicates) => predicates.All(x => x(@input));

    // IsEmpty
    public static bool IsEmpty<T>(this IEnumerable<T> @input) => @input is null || !@input.Any();
}