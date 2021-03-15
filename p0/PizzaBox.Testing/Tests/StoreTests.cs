using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing.Tests
{
  public class StoreTests
  {
    [Fact]
    public void Test_LoversStore_Fact()
    {
      // arrange
      var sut = new LoversStore();
      var expected = "Lovers Ln Store";

      // act
      var actual = sut.Name;

      // assert
      Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("Lovers Ln Store")]
    [InlineData("")]
    public void Test_LoversStore_Theory(string expected)
    {
      // arrange
      var sut = new LoversStore();

      // act
      var actual = sut.Name;

      // assert
      Assert.Equal(expected, actual);
    }
  }
}