using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Pizza 
    {
        [Key]
        public Guid PizzaId { get; set; } = Guid.NewGuid();
        public Component Size { get; set; } 
        public Component Crust { get; set; }
        ICollection<Component> Toppings { get; set; } = new List<Component>();
    }
}