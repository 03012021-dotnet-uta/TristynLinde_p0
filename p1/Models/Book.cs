using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Book
    {
        [Key]
        public Guid BookId { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public string Author { get; set; }
        public string Summary { get; set; }
        public decimal Price { get; set; }
        public int NumberAvailable { get; set; }
    }
}