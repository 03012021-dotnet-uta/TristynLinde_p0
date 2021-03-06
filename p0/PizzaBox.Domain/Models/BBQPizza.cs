using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class BBQPizza : APizza
    {
        public BBQPizza()
        {
            Crust = AddCrust();
            Size = AddSize();
            Toppings = AddToppings();
        }

        protected Crust AddCrust()
        {
            Crust crust = new Crust();
            crust.Name = "Thin";
            crust.Price = 0M;
            return crust;
        }

        protected List<Topping> AddToppings()
        {
            if (Toppings == null)
            {
                Toppings = new List<Topping>();
            }

            Topping top1 = new Topping();
            Topping top2 = new Topping();
            Topping top3 = new Topping();

            top1.Name = "Chicken";
            top2.Name = "Mushrooms";
            top3.Name = "Onions";

            List<Topping> toppings = new List<Topping> {
                top1, 
                top2, 
                top3
            };

            foreach (Topping top in toppings)
            {
                foreach (Topping t in Toppings)
                {
                    if (t.Name == top.Name)
                    {
                        Toppings.Remove(t);
                    }
                }
                Toppings.Add(top);
            }
            
            return Toppings;
        }
    }
}