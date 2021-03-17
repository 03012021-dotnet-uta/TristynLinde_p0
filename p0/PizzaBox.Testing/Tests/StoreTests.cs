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

    [Fact]
    public void Test_GarlandStore_Fact()
    {
      // arrange
      var sut = new GarlandStore();
      var expected = "Garland Rd Store";

      // act
      var actual = sut.Name;

      // assert
      Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test_MockingbirdStore_Fact()
    {
      // arrange
      var sut = new MockingbirdStore();
      var expected = "Mockingbird Ln Store";

      // act
      var actual = sut.Name;

      // assert
      Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test_WhitePizza1_Fact()
    {
      var sut = new WhitePizza();
      var expected = "Spinach";

      var actual = sut.Toppings[0].Name;

      Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test_WhitePizza2_Fact()
    {
      var sut = new WhitePizza();
      var expected = "Thin";

      var actual = sut.Crust.Name;

      Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test_BBQPizza1_Fact()
    {
      var sut = new BBQPizza();
      var expected = "Mushrooms";

      var actual = sut.Toppings[1].Name;

      Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test_BBQPizza2_Fact()
    {
      var sut = new BBQPizza();
      var expected = "Thin";

      var actual = sut.Crust.Name;

      Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test_RicottaPizza1_Fact()
    {
      var sut = new RicottaPizza();
      var expected = "Ricotta Cheese";

      var actual = sut.Toppings[2].Name;

      Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test_RicottaPizza2_Fact()
    {
      var sut = new RicottaPizza();
      var expected = "Thin";

      var actual = sut.Crust.Name;

      Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test_RicottaPizza3_Fact()
    {
      var sut = new RicottaPizza();
      var expected = "Basil";

      var actual = sut.Toppings[1].Name;

      Assert.Equal(expected, actual);
    }
  }
}