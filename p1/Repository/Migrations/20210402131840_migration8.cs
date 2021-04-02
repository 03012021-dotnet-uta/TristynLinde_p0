using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class migration8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: new Guid("5d30fdfb-b72c-4e05-a974-6c1af52f1ac7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: new Guid("6f6878f6-0fa1-4d71-b744-4bc6a7e5f847"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: new Guid("d99cce1b-e446-4a64-b671-5eb087d174e2"));

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "NumberAvailable", "OrderId", "Price", "Summary", "Title" },
                values: new object[] { new Guid("e34c4bf6-ef6a-4a4c-a484-06c6bbd21d9b"), "Antoine de Saint-Exupery", 15, null, 13.25m, "Written during World War II, The Little Prince tells of the friendship between the narrator, an aviator stranded in the Sahara desert, and a mysterious boy he encounters there. Ruler of a tiny asteroid of which he is the only inhabitant, the Little Prince chats disarmingly about his curious adventures in space and since arriving on earth; of his distant home; and of his love for a beautiful and capricious rose, to whom he longs to return. A moving and deceptively simple tale, it was described by Antoine de Saint-Exupery as a children's story for adults, and it works on several levels as an allegory of his own life and of the human condition. Children love it for its deadpan fantasy, for its sense of baffled amusement at the grown-up world, and for the author's whimsical watercolour illustrations, which are an integral part of the book.", "Le Petit Prince" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "NumberAvailable", "OrderId", "Price", "Summary", "Title" },
                values: new object[] { new Guid("822e4acb-a33f-46c2-8dc5-0d098c211d0b"), "Thomas Hobbes", 5, null, 23.50m, "Leviathan or The Matter, Forme and Power of a Common Wealth Ecclesiasticall and Civil-commonly referred to as Leviathan-is a book written by Thomas Hobbes (1588-1679) and published in 1651 (revised Latin edition 1668). Its name derives from the biblical Leviathan. The work concerns the structure of society and legitimate government, and is regarded as one of the earliest and most influential examples of social contract theory. Leviathan ranks as a classic western work on statecraft comparable to Machiavelli's The Prince. Written during the English Civil War (1642-1651), Leviathan argues for a social contract and rule by an absolute sovereign. Hobbes wrote that civil war and the brute situation of a state of nature (\"the war of all against all\") could only be avoided by strong, undivided government.", "Leviathan" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "NumberAvailable", "OrderId", "Price", "Summary", "Title" },
                values: new object[] { new Guid("72e1b890-eaf1-4baf-98b2-2823249f5d9c"), "Jacob and Wilhelm Grimm", 3, null, 19.25m, "The stories of magic and myth gathered by the Brothers Grimm have become part of the way children—and adults—learn about the vagaries of the real world. Cinderella, Rapunzel, Snow-White, Hänsel and Gretel, Little Red-Cap (Little Red Riding Hood), and Briar-Rose (Sleeping Beauty) are only a few of the more than two hundred enchanting characters included in this volume. The tales are presented just as Jacob and Wilhelm Grimm originally set them down: bold, primal, just frightening enough, and endlessly engaging.", "Grimm's Complete Fairy Tales" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: new Guid("72e1b890-eaf1-4baf-98b2-2823249f5d9c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: new Guid("822e4acb-a33f-46c2-8dc5-0d098c211d0b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: new Guid("e34c4bf6-ef6a-4a4c-a484-06c6bbd21d9b"));

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "NumberAvailable", "OrderId", "Price", "Summary", "Title" },
                values: new object[] { new Guid("d99cce1b-e446-4a64-b671-5eb087d174e2"), "Antoine de Saint-Exupery", 15, null, 13.25m, "Written during World War II, The Little Prince tells of the friendship between the narrator, an aviator stranded in the Sahara desert, and a mysterious boy he encounters there. Ruler of a tiny asteroid of which he is the only inhabitant, the Little Prince chats disarmingly about his curious adventures in space and since arriving on earth; of his distant home; and of his love for a beautiful and capricious rose, to whom he longs to return. A moving and deceptively simple tale, it was described by Antoine de Saint-Exupery as a children's story for adults, and it works on several levels as an allegory of his own life and of the human condition. Children love it for its deadpan fantasy, for its sense of baffled amusement at the grown-up world, and for the author's whimsical watercolour illustrations, which are an integral part of the book.", "Le Petit Prince" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "NumberAvailable", "OrderId", "Price", "Summary", "Title" },
                values: new object[] { new Guid("6f6878f6-0fa1-4d71-b744-4bc6a7e5f847"), "Thomas Hobbes", 5, null, 23.50m, "Leviathan or The Matter, Forme and Power of a Common Wealth Ecclesiasticall and Civil-commonly referred to as Leviathan-is a book written by Thomas Hobbes (1588-1679) and published in 1651 (revised Latin edition 1668). Its name derives from the biblical Leviathan. The work concerns the structure of society and legitimate government, and is regarded as one of the earliest and most influential examples of social contract theory. Leviathan ranks as a classic western work on statecraft comparable to Machiavelli's The Prince. Written during the English Civil War (1642-1651), Leviathan argues for a social contract and rule by an absolute sovereign. Hobbes wrote that civil war and the brute situation of a state of nature (\"the war of all against all\") could only be avoided by strong, undivided government.", "Leviathan" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "NumberAvailable", "OrderId", "Price", "Summary", "Title" },
                values: new object[] { new Guid("5d30fdfb-b72c-4e05-a974-6c1af52f1ac7"), "Jacob and Wilhelm Grimm", 3, null, 19.25m, "The stories of magic and myth gathered by the Brothers Grimm have become part of the way children—and adults—learn about the vagaries of the real world. Cinderella, Rapunzel, Snow-White, Hänsel and Gretel, Little Red-Cap (Little Red Riding Hood), and Briar-Rose (Sleeping Beauty) are only a few of the more than two hundred enchanting characters included in this volume. The tales are presented just as Jacob and Wilhelm Grimm originally set them down: bold, primal, just frightening enough, and endlessly engaging.", "Grimm's Complete Fairy Tales" });
        }
    }
}
