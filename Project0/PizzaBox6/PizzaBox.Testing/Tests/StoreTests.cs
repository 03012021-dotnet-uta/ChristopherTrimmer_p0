using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing.Tests
{
   /// <summary>
  /// Each DbSet has a respect XUnit Test file.
  /// Basic testing is performed on each DbSet class.
  /// </summary>
  public class StoreTests
  {
    [Fact]
    public void Test_Pittsburgh_Fact()
    {
      // arrange
      var sut = new Pittsburgh();
      var expected = "Pittsburgh";

      // act
      var actual = sut.Name;

      // assert
      Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("Pittsburgh")]
    [InlineData("Pitsburgh")]
    [InlineData("Pittsburg")]
    [InlineData("")]
    public void Test_Pittsburgh_Theory(string expected)
    {
      // arrange
      var sut = new Pittsburgh();

      // act
      var actual = sut.Name;

      // assert
      Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test_TampaBay_Fact()
    {
      // arrange
      var sut = new TampaBay();
      var expected = "Tampa Bay";

      // act
      var actual = sut.Name;

      // assert
      Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("Tampa Bay")]
    [InlineData("Pittsburgh")]
    public void Test_TampaBayStore_Theory(string expected)
    {
      // arrange
      var sut = new TampaBay();

      // act
      var actual = sut.Name;

      // assert
      Assert.Equal(expected, actual);
    }    

  }
}