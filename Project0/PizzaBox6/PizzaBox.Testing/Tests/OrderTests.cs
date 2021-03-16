using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing.Tests
{
  /// <summary>
  /// Each DbSet has a respect XUnit Test file.
  /// Basic testing is performed on each DbSet class.
  /// </summary>
 public class OrderTests
  {
    [Fact]
    public void Test_Order_Fact()
    {
      // arrange
      var sut = new Order();
      var expected = 0;

      // act
      var actual = sut.Pizzas.Count;

      // assert
      Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(1)]
    public void Test_Order_Theory(int expected)
    {
      // arrange
      var sut = new Order();

      // act
      var actual = sut.Pizzas.Count;

      // assert
      Assert.Equal(expected, actual);
    }

    

  }
}