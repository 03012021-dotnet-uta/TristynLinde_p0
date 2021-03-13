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
      // AsACustomer();
      startProgram();
    }

    /// <summary>
    /// 
    /// </summary>

    public static void AsACustomer()
    {
      var ss = StoreSingleton.Instance;

      ss.Seeding();

      // print all the stores available, must be from file or db
      foreach (var item in ss.Stores)
      {
        System.Console.WriteLine(item);
      }

      // select a store
      var input = Console.ReadLine();

      // print the customer menu
      System.Console.WriteLine("1. Place Order");
      System.Console.WriteLine("2. View Order History");
      System.Console.WriteLine("3. Exit");

      // select a menu option
      var input2 = Console.ReadLine();

      switch (input2)
      {
        case "1":
          // run the code dor placing order
          break;
        case "2":
          // run the code for view order history
          break;
      }
    }

    public static void startProgram()
    {
      System.Console.WriteLine("Welcome to Lover's Pizza. What would you like to do?");
      System.Console.WriteLine("1. Place Order");
      System.Console.WriteLine("2. View Order History");
      System.Console.WriteLine("3. Exit");

      var input = Console.ReadLine();

      switch (input)
      {
        case "1" :
          // var os = new OrderSingleton();
          // os.placeOrder();
          break;
        
        case "2" :
          view();
          break;

        case "3" :
          break;
        
        default: 
          Console.WriteLine("Please choose an option from the menu");
          startProgram();
          break;
      }
    }

    public static void view()
    {
      Console.WriteLine("view");
    }
  }
}
