using System.Xml.Serialization;

namespace PizzaBox.Domain.Models
{
  /// <summary>
  /// 
  /// </summary>

  [XmlInclude(typeof(Topping))]
  [XmlInclude(typeof(Crust))]
  [XmlInclude(typeof(Size))]
  public abstract class AComponent
  {
    public string Name { get; set; }
    public decimal Price { get; set; }
  }
}
