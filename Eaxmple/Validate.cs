
namespace functional_programming;
public static class Validate
{
    public static bool ValidatePassword(this string password, params Func<string, bool>[] predicates) => predicates.All(x => x(password));
    public static bool ValidatePasswordGeneric<TIn>(this TIn @input, params Func<TIn, bool>[] predicates) => predicates.All(x => x(@input));
}