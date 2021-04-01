using Microsoft.EntityFrameworkCore;
using Models;
using Microsoft.Extensions.Configuration;

namespace Repository
{
	public class loversContext : DbContext
	{
		public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
		public DbSet<Book> Books { get; set; }

		public loversContext(DbContextOptions<loversContext> options) : base(options)
		{ }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=LoversPizzaDB;Trusted_Connection=True;");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			modelBuilder.Entity<Book>().HasData(new Book {Title = "Le Petit Prince", Author = "Antoine de Saint-Exupery", Summary = "Written during World War II, The Little Prince tells of the friendship between the narrator, an aviator stranded in the Sahara desert, and a mysterious boy he encounters there. Ruler of a tiny asteroid of which he is the only inhabitant, the Little Prince chats disarmingly about his curious adventures in space and since arriving on earth; of his distant home; and of his love for a beautiful and capricious rose, to whom he longs to return. A moving and deceptively simple tale, it was described by Antoine de Saint-Exup???ry as a children's story for adults, and it works on several levels as an allegory of his own life and of the human condition. Children love it for its deadpan fantasy, for its sense of baffled amusement at the grown-up world, and for the author's whimsical watercolour illustrations, which are an integral part of the book.", Price = 13.25M, NumberAvailable = 15});
			modelBuilder.Entity<Book>().HasData(new Book {Title = "Leviathan", Author = "Thomas Hobbes", Summary = "Leviathan or The Matter, Forme and Power of a Common Wealth Ecclesiasticall and Civil-commonly referred to as Leviathan-is a book written by Thomas Hobbes (1588-1679) and published in 1651 (revised Latin edition 1668). Its name derives from the biblical Leviathan. The work concerns the structure of society and legitimate government, and is regarded as one of the earliest and most influential examples of social contract theory. Leviathan ranks as a classic western work on statecraft comparable to Machiavelli's The Prince. Written during the English Civil War (1642-1651), Leviathan argues for a social contract and rule by an absolute sovereign. Hobbes wrote that civil war and the brute situation of a state of nature (\"the war of all against all\") could only be avoided by strong, undivided government.", Price = 23.50M, NumberAvailable = 5});
			modelBuilder.Entity<Book>().HasData(new Book {Title = "Grimm's Complete Fairy Tales", Author = "Jacob and Wilhelm Grimm", Summary = "The stories of magic and myth gathered by the Brothers Grimm have become part of the way children—and adults—learn about the vagaries of the real world. Cinderella, Rapunzel, Snow-White, Hänsel and Gretel, Little Red-Cap (Little Red Riding Hood), and Briar-Rose (Sleeping Beauty) are only a few of the more than two hundred enchanting characters included in this volume. The tales are presented just as Jacob and Wilhelm Grimm originally set them down: bold, primal, just frightening enough, and endlessly engaging.", Price = 19.25M, NumberAvailable = 3});
		}
	}
}