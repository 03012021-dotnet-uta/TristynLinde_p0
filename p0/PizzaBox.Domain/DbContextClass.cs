using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain
{
    public class DbContextClass : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<APizza> Pizzas { get; set; }
        public DbSet<AStore> Stores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=PizzaBox-DB;Trusted_Connection=True;");
        }
    }
}