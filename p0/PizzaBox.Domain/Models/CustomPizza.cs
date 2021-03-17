using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class CustomPizza : APizza
  {
    public CustomPizza()
    {
      Size = AddSize();
      Crust = AddCrust();
      Toppings = AddToppings();
    }

    protected Crust AddCrust()
    {
      Crust c = new Crust();
      return c;
    }

    protected List<Topping> AddToppings()
    {
      List<Topping> t = new List<Topping>();

      return t;
    }
  }
}
