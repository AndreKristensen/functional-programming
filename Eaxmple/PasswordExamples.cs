using System.Text.RegularExpressions;

namespace functional_programming;

public class PasswordExamples
{
    public static bool PasswordValidation(string password)
    {

        if (password.Length <= 11)
        {
            return false;
        }

        var captialLetters = new Regex("[A-Z]+").IsMatch(password);
        if (!captialLetters)
        {
            return false;
        }
        var lowerCaseLetters = new Regex("[a-z]+").IsMatch(password);
        if (!lowerCaseLetters)
        {
            return false;
        }

        var numbers = new Regex("[0-9]+").IsMatch(password);
        if (!numbers)
        {
            return false;
        }

        return true;
    }

    public static readonly Func<string, bool> AtLeastTwelveCharacters = password => password.Length > 11;
    public static readonly Func<string, bool> ContainCapitalLetters = password => new Regex("[A-Z]+").IsMatch(password);
    public static readonly Func<string, bool> ContainLowerCaseLetters = password => new Regex("[a-z]+").IsMatch(password);
    public static readonly Func<string, bool> ContainNumbers = password => new Regex("[0-9]+").IsMatch(password);

    public static bool ValidatePasswordPolicy(string password) =>
         new[]
         {
            AtLeastTwelveCharacters,
            ContainCapitalLetters,
            ContainLowerCaseLetters,
            ContainNumbers,
         }.All(x => x(password));


    public static bool ValidatePasswordPolicy_2(string password) => 
        password.ValidatePassword(
            AtLeastTwelveCharacters,
            ContainCapitalLetters,
            ContainLowerCaseLetters,
            ContainNumbers);

}