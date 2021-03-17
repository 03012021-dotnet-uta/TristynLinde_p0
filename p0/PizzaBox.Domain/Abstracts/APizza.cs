using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{
  /// <summary>
  /// 
  /// </summary>

  [XmlInclude(typeof(CustomPizza))]
  [XmlInclude(typeof(BBQPizza))]
  [XmlInclude(typeof(RicottaPizza))]
  [XmlInclude(typeof(WhitePizza))]
  public abstract class APizza
  {
    public Crust Crust { get; set; }
    public Size Size { get; set; }
    public List<Topping> Toppings { get; set; }
    protected bool success = false;

    public bool getSuccess()
    {
      if (!(Crust.Name.Equals("") || Size.Name.Equals("")))
        success = true;

      foreach (Topping t in Toppings)
        if (t.Name.Equals(""))
          success = false;
          
      return success;
    }

    protected Size AddSize()
    {
      Size s = new Size();
      return s;
    }
  }
}
