using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Models
{
    public class Order
    {
        [Key]
        public Guid OrderId { get; set; } = Guid.NewGuid();
        public Guid CustomerId { get; set; }
        public DateTime Time { get; set; } = DateTime.Now;

        ICollection<Pizza> Pizzas { get; set; } = new List<Pizza>();
    }
}