using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{
  /// <summary>
  /// 
  /// </summary>
  [XmlInclude(typeof(LoversStore))]
  [XmlInclude(typeof(MockingbirdStore))]
  [XmlInclude(typeof(GarlandStore))]
  public abstract class AStore
  {
    public string Name { get; set; }
    // public List<Order> Orders { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
      return Name;
    }
  }
}
