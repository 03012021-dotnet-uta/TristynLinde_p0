using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    class BBQPizza : APizza
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

            top1.Name = "Chicken";
            top2.Name = "Mushrooms";
            top3.Name = "Onions";

            Toppings = new List<Topping>
            {
                top1,
                top2,
                top3
            };
        }
    }
}