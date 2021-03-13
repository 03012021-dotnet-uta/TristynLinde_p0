using System.Collections.Generic;

namespace PizzaBox.Domain.Abstracts
{
  /// <summary>
  /// 
  /// </summary>
  public abstract class AOrder
  {
    public List<APizza> Pizzas { get; set; }
    public ACustomer Customer { get; set; }
    public AStore Store { get; set; }
  }
}
