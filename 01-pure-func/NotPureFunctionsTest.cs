using FluentAssertions;
using functional_programming;
using NUnit.Framework;

[TestFixture]
public class NotPureFunctionsTest
{

    [Test]
    public void IsOver18_test()
    {
        DateTime age = DateTime.Today.AddYears(-18);

        Console.WriteLine(age.ToString());
        Console.WriteLine(DateTime.Today.AddYears(-18).ToString());

        NotPureFunctions.IsOver18(age).Should().BeTrue();
    }

    public static List<string> names = new List<string>() { "1John", "2Melcy", "3Thor", "4John1", "5Melcy2", "6Thor2", "7John3", "8Melcy3", "9Thor3" };

    [Test]
    public void test()
    {
        var NotPureParallel = NotPureFunctions.NotPureParallel(names);
        NotPureParallel.ForEach(Console.WriteLine);
    }
   


}