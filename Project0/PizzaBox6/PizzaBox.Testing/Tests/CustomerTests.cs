using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing.Tests
{

  /// <summary>
  /// Each DbSet has a respect XUnit Test file.
  /// Basic testing is performed on each DbSet class.
  /// </summary>

  public class CustomerTests
  {
    [Fact]
    public void Test_Customer_Fact()
    {
      // arrange
      var sut = new Customer();
      var expected = "Customer";

      // act
      var actual = sut.Name;

      // assert
      Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("Customer")]
    [InlineData("")]
    public void Test_Customer_Theory(string expected)
    {
      // arrange
      var sut = new Customer();

      // act
      var actual = sut.Name;

      // assert
      Assert.Equal(expected, actual);
    }

    

  }
}