using System;
using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class Order
  {
    public Customer Customer { get; set; }
    public AStore Store { get; set; }
    public List<APizza> Pizzas { get; set; }
    public decimal Price { get; set; }

    private bool _ordered = false;

    public bool hasOrder()
    {
      return _ordered;
    }

    public void placeOrder()
    {
      Console.WriteLine("Which store would you like to order from?");
      Console.WriteLine("1. Lovers Ln Store");
      Console.WriteLine("2. Garland Rd Store");
      Console.WriteLine("3. Mockingbird Ln Store");

      var input = Console.ReadLine();

      while (!(input.Equals("1") || input.Equals("2") || input.Equals("3")))
      {
        Console.WriteLine("Please choose an option from the list.");
        input = Console.ReadLine();
      }

      switch (input)
      {
        case "1" :
          AStore store1 = new LoversStore();
          Store = store1;
        break;

        case "2" :
          AStore store2 = new GarlandStore();
          Store = store2;
        break;

        case "3" :
          AStore store3 = new MockingbirdStore();
          Store = store3;
        break;
      }

      orderPizza();
    }

    protected void orderPizza()
    {
      Console.WriteLine("Would you like to order from our menu or create a custom pizza?");
      Console.WriteLine("1. Our Menu");
      Console.WriteLine("2. Custom Pizza");

      var input = Console.ReadLine();

      while (!(input.Equals("1") || input.Equals("2")))
      {
        Console.WriteLine("Please choose an option from the list.");
        input = Console.ReadLine();
      }

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
      }
    }

    protected void premadePizza()
    {
      Console.WriteLine("Choose a pizza to add to your order");
      Console.WriteLine("1. White Pizza");
      Console.WriteLine("2. Ricotta Pizza");
      Console.WriteLine("3. Barbecue Chicken Pizza");

      var input = Console.ReadLine();

      while (!(input.Equals("1") || input.Equals("2") || input.Equals("3")))
      {
        Console.WriteLine("Please choose an option from the list.");
        input = Console.ReadLine();
      }

      switch(input)
      {
        case "1" :
          APizza toAdd1 = new WhitePizza();
          toAdd1.Size = chooseSize();
          if (toAdd1.getSuccess())
          {
            addPizzaToOrder(toAdd1);
          }
        break;
        
        case "2" :
          APizza toAdd2 = new RicottaPizza();
          toAdd2.Size = chooseSize();
          if (toAdd2.getSuccess())
          {
            addPizzaToOrder(toAdd2);
          }
        break;

        case "3" :
          APizza toAdd3 = new BBQPizza();
          toAdd3.Size = chooseSize();
          if (toAdd3.getSuccess())
          {
            addPizzaToOrder(toAdd3);
          }
        break;
      }
    }

    protected void customPizza()
    {
      CustomPizza toAdd = new CustomPizza();
      toAdd.Size = chooseSize();
      toAdd.Crust = chooseCrust();
      toAdd.Toppings = chooseToppings();
      if (toAdd.getSuccess())
        addPizzaToOrder(toAdd);
      else
      {
        Console.WriteLine("Pizza cannot be added to order.");
        doNext();
      }
    }

    protected Size chooseSize()
    {
      var size = new Size();

      Console.WriteLine("Which size pizza would you like?");
      Console.WriteLine("1. Small (12 inches) - $10.00");
      Console.WriteLine("2. Medium (14 inches) - $12.00");
      Console.WriteLine("3. Large (16 inches) - $13.50");

      var input = Console.ReadLine();

      while (!(input.Equals("1") || input.Equals("2") || input.Equals("3")))
      {
        Console.WriteLine("Please choose an option from the list.");
        input = Console.ReadLine();
      }

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
      }

      return size;
    }

    protected Crust chooseCrust()
    {
      var crust = new Crust();

      Console.WriteLine("Which type of crust would you like?");
      Console.WriteLine("1. Thin");
      Console.WriteLine("2. Thick - Adds $4.99");

      var input = Console.ReadLine();

      while (!(input.Equals("1") || input.Equals("2")))
      {
        Console.WriteLine("Please choose an option from the list.");
        input = Console.ReadLine();
      }

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
      }

      return crust;
    }

    protected List<Topping> chooseToppings()
    {
      List<Topping> toppings = new List<Topping>();

      Console.WriteLine("Which toppings would you like?");
      Console.WriteLine("1. Pepperoni");
      Console.WriteLine("2. Tomatoes");
      Console.WriteLine("3. Onions");
      Console.WriteLine("4. Canadian Bacon");
      Console.WriteLine("5. Italian Sausage");
      Console.WriteLine("6. Olives");
      Console.WriteLine("7. Pineapple");
      Console.WriteLine("8. Extra Cheese");
      Console.WriteLine("9. Order Pizza");

      toppings = addTopping(toppings, 5);
      return toppings;
    }

    protected List<Topping> addTopping(List<Topping> list, int count)
    {
      var input = Console.ReadLine();

      while (!(input.Equals("1") || input.Equals("2") || input.Equals("3") || input.Equals("4") || input.Equals("5") || input.Equals("6") || input.Equals("7") || input.Equals("8") || input.Equals("9")))
      {
        Console.WriteLine("Please choose an option from the list.");
        input = Console.ReadLine();
      }

      if (count != 0 || input == "9")
      {
        Topping top = new Topping();

        switch(input)
        {
          case "1" :
            top.Name = "Pepperoni";
          break;

          case "2" :
            top.Name = "Tomatoes";
          break;
          
          case "3" :
            top.Name = "Onion";
          break;

          case "4" :
            top.Name = "Canadian Bacon";
          break;

          case "5" :
            top.Name = "Italian Sausage";
          break;

          case "6" :
            top.Name = "Olives";
          break;

          case "7" :
            top.Name = "Pineapple";
          break;

          case "8" :
            top.Name = "Extra Cheese";
          break;

          case "9" :
          break;
        }

        switch(input)
        {
          case "1" : case "2" : case "3" : case "4" : case "5" : case "6" : case "7" : case "8" : 
            list.Add(top);
            list = addTopping(list, count - 1);
          break;
        }
      }
      else
      {
        Console.WriteLine("Cannot add more than 5 toppings");
        list = addTopping(list, count);
      }
      return list;
    }

    protected void addPizzaToOrder(APizza pizza)
    {
      pizza.Price = pizza.Crust.Price + pizza.Size.Price;
      foreach(Topping t in pizza.Toppings)
      {
        pizza.Price += t.Price;
      }

      if (Pizzas == null)
      {
        Pizzas = new List<APizza>();
      }
      Pizzas.Add(pizza);
      _ordered = true;
      Console.WriteLine("Your pizza has been added to your order.");
      Console.WriteLine();
      doNext();
    }

    protected void doNext()
    {
      viewOrder();
      
      Console.WriteLine("What would you like to do next?");
      Console.WriteLine("1. Add another pizza");
      Console.WriteLine("2. Checkout");

      var input = Console.ReadLine();

      while (!(input.Equals("1") || input.Equals("2")))
      {
        Console.WriteLine("Please choose an option from the list.");
        input = Console.ReadLine();
      }

      switch(input)
      {
        case "1" :
          orderPizza();
        break;

        case "2" :
        break;
      }
    }
    
    public void viewOrder()
    {
      Console.WriteLine();
      Console.WriteLine("Your order:");

      Price = 0;
      
      foreach (APizza p in Pizzas)
      {
        Console.Write(p.Size.Name + " pizza with " + p.Crust.Name.ToLower() + " crust and ");

        Topping last = p.Toppings.Last();
        foreach (Topping t in p.Toppings)
        {
          if (t != last)
            Console.Write(t.Name + ", ");
          else 
            Console.WriteLine("and " + t.Name);
        }

        Price += p.Price;
      }
      Console.WriteLine("Your total order price is " + Price);
      Console.WriteLine();
    }

    
  }
}
