using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class Order
  {

    public Guid orderID = new Guid();
    public Customer Customer { get; set; }
    public AStore Store { get; set; }
    public List<APizza> Pizzas { get; set; }

    public bool ordered = false;

    public bool hasOrder()
    {
      return ordered;
    }

    public void placeOrder()
    {
      Console.WriteLine("Would you like to order from our menu or create a custom pizza?");
      Console.WriteLine("1. Our Menu");
      Console.WriteLine("2. Custom Pizza");
      Console.WriteLine("3. Go Back");

      var input = Console.ReadLine();

      switch(input)
      {
        case "1" :
          premadePizza();
          break;
        
        case "2" :
          customPizza();
          break;
        
        case "3" :
          break;

        default :
          Console.WriteLine("Please choose an option from the list");
          break;
      }
    }

    protected void premadePizza()
    {
      Console.WriteLine("Choose a pizza to add to your order");
      Console.WriteLine("1. White Pizza");
      Console.WriteLine("2. Ricotta Pizza");
      Console.WriteLine("3. Barbecue Chicken Pizza");
      Console.WriteLine("4. Go Back");

      var input = Console.ReadLine();

      switch(input)
      {
        case "1" :
          APizza toAdd1 = new WhitePizza();
          toAdd1.Size = chooseSize();
          if (toAdd1.Size != null)
          {
            addPizzaToOrder(toAdd1);
          }
        break;
        
        case "2" :
          APizza toAdd2 = new RicottaPizza();
          toAdd2.Size = chooseSize();
          if (toAdd2.Size != null)
          {
            addPizzaToOrder(toAdd2);
          }
        break;

        case "3" :
          APizza toAdd3 = new BBQPizza();
          toAdd3.Size = chooseSize();
          if (toAdd3.Size != null)
          {
            addPizzaToOrder(toAdd3);
          }
        break;

        case "4" :
          placeOrder();
        break;

        default: 
          Console.WriteLine("Please choose an option from the list");
        break;
      }
    }

    protected void customPizza()
    {
      CustomPizza toAdd = new CustomPizza();
      toAdd.Size = chooseSize();
      toAdd.Crust = chooseCrust();
      toAdd.Toppings
    }

    protected Crust chooseSize()
    {
      var crust = new Crust();

      Console.WriteLine("Which type of crust would you like?");
      Console.WriteLine("1. Thin");
      Console.WriteLine("2. Thick - Adds $4.99");
      Console.WriteLine("3. Go Back");

      var input = Console.ReadLine();

      switch(input)
      {
        case "1" :
          crust.Name = "Thin";
          crust.Price = 0M;
        break;

        case "2" :
          crust.Name = "Thick";
          crust.Price = 4.99M;
        break;

        case "4" :
        break;

        default: 
          Console.WriteLine("Please choose an option from the list");
        break;
      }

      return crust;
    }

    protected Size chooseSize()
    {
      var size = new Size();

      Console.WriteLine("Which size pizza would you like?");
      Console.WriteLine("1. Small (12 inches) - $10.00");
      Console.WriteLine("2. Medium (14 inches) - $12.00");
      Console.WriteLine("3. Large (16 inches) - $13.50");
      Console.WriteLine("4. Go Back");

      var input = Console.ReadLine();

      switch(input)
      {
        case "1" :
          size.Name = "Small";
          size.Price = 10.00M;
        break;

        case "2" :
          size.Name = "Medium";
          size.Price = 12.00M;
        break;

        case "3" :
          size.Name = "Large";
          size.Price = 13.50M;
        break;

        case "4" :
        break;

        default: 
          Console.WriteLine("Please choose an option from the list");
        break;
      }

      return size;
    }

    protected void addPizzaToOrder(APizza pizza)
    {
      ordered = true;
      if (Pizzas == null)
      {
        Pizzas = new List<APizza>();
      }
      Pizzas.Add(pizza);

      Console.WriteLine("Pizza added to order. Would you like to add another pizza or check out?");
      Console.WriteLine("1. Add another pizza");
      Console.WriteLine("2. Check out");

      var input = Console.ReadLine();

      switch(input)
      {
        case "1" :
          placeOrder();
        break;

        case "2" :
          checkout();
        break;

        default:
          Console.WriteLine("Please choose an option from the list.");
        break;
      }
    }

    protected void checkout()
    {
      Console.WriteLine("checkout");
    }

  }
}
