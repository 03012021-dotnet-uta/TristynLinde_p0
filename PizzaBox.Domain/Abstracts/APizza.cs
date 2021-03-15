using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{
  /// <summary>
  /// 
  /// </summary>
  public abstract class APizza
  {
    public Crust Crust { get; set; }
    public Size Size { get; set; }
    public List<Topping> Toppings { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public APizza()
    {
      AddCrust();
      AddSize();
      AddToppings();
    }

    protected abstract void AddCrust();
    protected abstract void AddSize();
    protected abstract void AddToppings();
  }
}
