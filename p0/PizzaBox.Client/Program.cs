using System;
using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain;
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
    public static List<Order> Orders { get; set; }

    /// <summary>
    /// 
    /// </summary>
    static void Main(string[] args)
    {
      int maxCount = 5;
      startProgram(maxCount);
    }

    protected static void startProgram(int count)
    {
      var os = new Order();
      count--;

      System.Console.WriteLine("Welcome to Lover's Pizza. What would you like to do?");
      System.Console.WriteLine("1. Place Order");
      System.Console.WriteLine("2. View Order History");
      System.Console.WriteLine("3. Exit");

      var input = Console.ReadLine();

      switch (input)
      {
        case "1" :
          os.placeOrder();
          if (!os.hasOrder())
          {
            startProgram(count);
          }
          checkout(os);
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
      var os = OrderSingleton.Instance;
      var orders = os.Deserialize();

      Console.WriteLine("Please enter your name:");

      var input = Console.ReadLine();

      foreach (Order o in orders)
      {
        if (o.Customer.Name == input)
        {
          Console.WriteLine(o.Pizzas.Count + " pizza(s): ");
          foreach (APizza p in o.Pizzas)
          {
            Console.Write(p.Size.Name + " pizza with " + p.Crust.Name.ToLower() + " crust and ");

            Topping last = p.Toppings.Last();
            bool repeat;
            foreach (Topping t in p.Toppings)
            {
                repeat = false;
                var index1 = p.Toppings.IndexOf(t);

                foreach (Topping c in p.Toppings)
                {
                  var index2 = p.Toppings.IndexOf(c);

                  if (index1 != index2 && index2 > index1 && t.Name == c.Name)
                  {
                    repeat = true;
                  }
                }

                if (!repeat)
                {
                  if (t != last)
                    Console.Write(t.Name + ", ");
                  else 
                    Console.WriteLine("and " + t.Name + " - " + p.Price);
                }
            }
          }
          Console.WriteLine("Total Price: " + o.Price);
          Console.WriteLine();
        }
      }
    }

    protected static void checkout(Order order)
    {
      var os = OrderSingleton.Instance;
      
      Console.WriteLine("Please enter your name:");

      if (order.Customer == null)
      {
        order.Customer = new Customer();
      }
      order.Customer.Name = Console.ReadLine();
      
      os.Serialize(order);

      Console.WriteLine("Thank you for ordering from Lover's Pizza!");
    }
  }
}
