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
  
  [XmlInclude(typeof(LoversStore))]
  [XmlInclude(typeof(GarlandStore))]
  [XmlInclude(typeof(MockingbirdStore))]
  public abstract class AStore
  {
    public string Name { get; set; }
  }
}
