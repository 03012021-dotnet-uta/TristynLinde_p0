// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

namespace Repository.Migrations
{
    [DbContext(typeof(loversContext))]
    [Migration("20210401225648_migration6")]
    partial class migration6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Models.Book", b =>
                {
                    b.Property<Guid>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberAvailable")
                        .HasColumnType("int");

                    b.Property<Guid?>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookId");

                    b.HasIndex("OrderId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = new Guid("de9bbf43-5286-4da2-b786-6d7943673a79"),
                            Author = "Antoine de Saint-Exupery",
                            NumberAvailable = 15,
                            Price = 13.25m,
                            Summary = "Written during World War II, The Little Prince tells of the friendship between the narrator, an aviator stranded in the Sahara desert, and a mysterious boy he encounters there. Ruler of a tiny asteroid of which he is the only inhabitant, the Little Prince chats disarmingly about his curious adventures in space and since arriving on earth; of his distant home; and of his love for a beautiful and capricious rose, to whom he longs to return. A moving and deceptively simple tale, it was described by Antoine de Saint-Exup???ry as a children's story for adults, and it works on several levels as an allegory of his own life and of the human condition. Children love it for its deadpan fantasy, for its sense of baffled amusement at the grown-up world, and for the author's whimsical watercolour illustrations, which are an integral part of the book.",
                            Title = "Le Petit Prince"
                        },
                        new
                        {
                            BookId = new Guid("cc08471b-b967-427e-90dc-552ef46704c6"),
                            Author = "Thomas Hobbes",
                            NumberAvailable = 5,
                            Price = 23.50m,
                            Summary = "Leviathan or The Matter, Forme and Power of a Common Wealth Ecclesiasticall and Civil-commonly referred to as Leviathan-is a book written by Thomas Hobbes (1588-1679) and published in 1651 (revised Latin edition 1668). Its name derives from the biblical Leviathan. The work concerns the structure of society and legitimate government, and is regarded as one of the earliest and most influential examples of social contract theory. Leviathan ranks as a classic western work on statecraft comparable to Machiavelli's The Prince. Written during the English Civil War (1642-1651), Leviathan argues for a social contract and rule by an absolute sovereign. Hobbes wrote that civil war and the brute situation of a state of nature (\"the war of all against all\") could only be avoided by strong, undivided government.",
                            Title = "Leviathan"
                        },
                        new
                        {
                            BookId = new Guid("8de8bf6f-dd08-46bd-b1ee-4f86f30d8627"),
                            Author = "Jacob and Wilhelm Grimm",
                            NumberAvailable = 3,
                            Price = 19.25m,
                            Summary = "The stories of magic and myth gathered by the Brothers Grimm have become part of the way children—and adults—learn about the vagaries of the real world. Cinderella, Rapunzel, Snow-White, Hänsel and Gretel, Little Red-Cap (Little Red Riding Hood), and Briar-Rose (Sleeping Beauty) are only a few of the more than two hundred enchanting characters included in this volume. The tales are presented just as Jacob and Wilhelm Grimm originally set them down: bold, primal, just frightening enough, and endlessly engaging.",
                            Title = "Grimm's Complete Fairy Tales"
                        });
                });

            modelBuilder.Entity("Models.Customer", b =>
                {
                    b.Property<Guid>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Fname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Models.Order", b =>
                {
                    b.Property<Guid>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Store")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Models.Book", b =>
                {
                    b.HasOne("Models.Order", null)
                        .WithMany("Books")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("Models.Order", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
