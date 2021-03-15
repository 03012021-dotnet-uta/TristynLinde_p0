using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Singletons;

namespace PizzaBox.Client
{
  /// <summary>
  /// 
  /// </summary>
  class Program
  {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
      int maxCount = 5;
      startProgram(maxCount);
    }

    public static void startProgram(int count)
    {
      count--;

      System.Console.WriteLine("Welcome to Lover's Pizza. What would you like to do?");
      System.Console.WriteLine("1. Place Order");
      System.Console.WriteLine("2. View Order History");
      System.Console.WriteLine("3. Exit");

      var input = Console.ReadLine();

      switch (input)
      {
        case "1" :
          var os = new Order();
          os.placeOrder();
          if (!os.hasOrder())
          {
            startProgram(count);
          }
        break;
        
        case "2" :
          view();
        break;

        case "3" :
        break;
        
        default: 
          if (count != 0)
          {
            Console.WriteLine("Please choose an option from the menu");
            startProgram(count);
          }
          else
          {
            Console.WriteLine("Exceeded number of invalid entries");
          }
        break;
      }
    }

    public static void view()
    {
      Console.WriteLine("view");
    }
  }
}
