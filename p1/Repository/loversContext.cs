using Microsoft.EntityFrameworkCore;
using Models;

namespace Repository
{
	public class loversContext : DbContext
	{
		public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
		public DbSet<Pizza> Pizzas { get; set; }

		public loversContext(DbContextOptions<loversContext> options) : base(options)
		{ }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
		}
	}
}