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
        public string Store { get; set; }
        public DateTime Time { get; set; } = DateTime.Now;
        public decimal Price { get; set; }
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}