using NUnit.Framework;
using FluentAssertions;

using functional_programming;

[TestFixture]
public class MonadsTests
{
    [Test]
    public void FahrenheitToCelsius_test()
    {
        var celsius = Monads.FahrenheitToCelsius(100M);
        celsius.Should().Be($"{37.78}°C");
        var celsius2 = Monads.FahrenheitToCelsius(212M);
        celsius2.Should().Be($"{100.00}°C");
    }
    [Test]
    public void CelsiusToFahrenheit_test()
    {


        var fahrenheit = Monads.CelsiusToFahrenheit(37.78M);
        fahrenheit.Should().Be($"{100}°F");
        var fahrenheit2 = Monads.CelsiusToFahrenheit(100M);


        fahrenheit2.Should().Be($"{212}°F");
        fahrenheit2.Should().Be($"{212}°F");
    }

    [Test]
    public void FindRickAndMortyCharacter_test()
    {
      Monads.FindRickAndMortyCharacter(1).Should().Be("Rick Sanchez is a Rick and Morty character");
      Monads.FindRickAndMortyCharacter(-2).Should().BeNull();
    }


}