using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing.Tests
{
  /// <summary>
  /// Each DbSet has a respect XUnit Test file.
  /// Basic testing is performed on each DbSet class.
  /// </summary>
public class PizzaTests
  {
    [Fact]
    public void Test_CheesePizza_Fact()
    {
      // arrange
      var sut = new CheesePizza();
      var expected = "Cheese Pizza";

      // act
      var actual = sut.Name;

      // assert
      Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("Cheese Pizza")]
    [InlineData("Custom Pizza")]
    public void Test_CheesePizza_Theory(string expected)
    {
      // arrange
      var sut = new CheesePizza();

      // act
      var actual = sut.Name;

      // assert
      Assert.Equal(expected, actual);
    }

    

  }
}