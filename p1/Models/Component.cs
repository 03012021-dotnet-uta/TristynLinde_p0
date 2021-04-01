using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Component
    {
        [Key]
        public Guid ComponentID { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}