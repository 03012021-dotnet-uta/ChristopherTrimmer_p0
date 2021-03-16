using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing.Tests
{

  /// <summary>
  /// Each DbSet has a respect XUnit Test file.
  /// Basic testing is performed on each DbSet class.
  /// </summary>

  public class MozzarellaTests
  {
    [Fact]
    public void Test_Mozzarella_Fact()
    {
      // arrange
      var sut = new Mozzarella();
      var expected = "Mozzarella";

      // act
      var actual = sut.Name;

      // assert
      Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("Mozzarella")]
    [InlineData("Mozarella")]
    [InlineData("Mozzarela")]
    [InlineData("")]
    public void Test_Mozzarella_Theory(string expected)
    {
      // arrange
      var sut = new Mozzarella();

      // act
      var actual = sut.Name;

      // assert
      Assert.Equal(expected, actual);
    }

    

  }
}