using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class CustomPizza : APizza
  {

    protected override void AddCrust()
    {
      throw new System.NotImplementedException();
    }

    protected override void AddSize()
    {
      throw new System.NotImplementedException();
    }

    protected override void AddToppings()
    {
      throw new System.NotImplementedException();
    }
  }
}
