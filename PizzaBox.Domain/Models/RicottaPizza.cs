using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    class RicottaPizza : APizza
    {
        protected override void AddCrust()
        {
            Crust = new Crust();
            Crust.Name = "Thin";
            Crust.Price = 0M;
        }

        protected override void AddSize()
        {
            Size = new Size();
        }

        protected override void AddToppings()
        {
            Topping top1 = new Topping();
            Topping top2 = new Topping();
            Topping top3 = new Topping();

            top1.Name = "Tomatos";
            top2.Name = "Basil";
            top3.Name = "Ricotta Cheese";

            Toppings = new List<Topping>
            {
                top1,
                top2,
                top3
            };
        }
    }
}