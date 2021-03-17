using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class WhitePizza : APizza
    {
        public WhitePizza()
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
            Topping top1 = new Topping();
            Topping top2 = new Topping();
            Topping top3 = new Topping();

            top1.Name = "Spinach";
            top2.Name = "Broccoli";
            top3.Name = "Bell Peppers";

            List<Topping> toppings = new List<Topping> {
                top1,
                top2,
                top3
            };

            return toppings;
        }
    }
}