using NUnit.Framework;
using functional_programming;

[TestFixture]
public class PasswordExamplesTest
{

    [Test]
    public void TestFunc_ReturnsTrueForValidPassword()
    {
        // Arrange
        string password = "Abcdefghijklm123!";

        bool result = PasswordExamples.AtleastTwelveCharacters(password);
        bool result1 = PasswordExamples.ContainCaptialLetters(password);
        bool result2 = PasswordExamples.ContainLowerCaseLetters(password);
        bool result3 = PasswordExamples.ContainNumbers(password);

        // Assert
        Assert.IsTrue(result);
        Assert.IsTrue(result1);
        Assert.IsTrue(result2);
        Assert.IsTrue(result3);
    }

    [Test]
    public void TestFunc_ReturnsFalseForValidPassword()
    {
        // Arrange

        // Act
        bool result = PasswordExamples.AtleastTwelveCharacters("password");
        bool result1 = PasswordExamples.ContainCaptialLetters("password");
        bool result2 = PasswordExamples.ContainLowerCaseLetters("ASDASD");
        bool result3 = PasswordExamples.ContainNumbers("password");

        // Assert
        Assert.IsFalse(result);
        Assert.IsFalse(result1);
        Assert.IsFalse(result2);
        Assert.IsFalse(result3);
    }


    [Test]
    public void PasswordValidation_ReturnsTrueForValidPassword()
    {
        // Arrange
        string password = "Abcdefghijklm123!";

        // Act
        bool result = PasswordExamples.PasswordValidation(password);
        bool result2 = PasswordExamples.ValidatePassword(password);
        bool result3 = PasswordExamples.ValidatePassword2(password);

        // Assert
        Assert.IsTrue(result);
        Assert.IsTrue(result2);
        Assert.IsTrue(result3);
    }

    [Test]
    public void PasswordValidation_ReturnsFalseForValidPassword()
    {
        // Arrange
        string password = "Abcdefghijklm!";

        // Act
        bool result = PasswordExamples.PasswordValidation(password);
        bool result2 = PasswordExamples.ValidatePassword(password);
        bool result3 = PasswordExamples.ValidatePassword2(password);

        // Assert
        Assert.IsFalse(result);
        Assert.IsFalse(result2);
        Assert.IsFalse(result3);
    }
}