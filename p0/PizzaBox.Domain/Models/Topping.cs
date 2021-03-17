using System;
using System.ComponentModel.DataAnnotations;

namespace PizzaBox.Domain.Models
{
  public class Topping : AComponent
  {
    public Topping()
    {
      Price = 1M;
    }

  }
}