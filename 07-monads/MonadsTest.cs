using NUnit.Framework;
using FluentAssertions;

using functional_programming;

[TestFixture]
public class MonadsTests
{
    [Test]
    public void FarneheitToCelsius_test()
    {
        var celsius = Monads.FarneheitToCelsius(100M);
        celsius.Should().Be($"{37.78}°C");
    }
    [Test]
    public void FindRickAndMortyCharacter_test()
    {
      Monads.FindRickAndMortyCharacter(1).Should().Be("Rick Sanchez is a Rick and Morty character");
      Monads.FindRickAndMortyCharacter(-1).Should().BeNull();
    }


}