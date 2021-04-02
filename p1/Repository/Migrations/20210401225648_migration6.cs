using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class migration6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: new Guid("0ee49a28-7699-4182-ae06-b105d7f1f8dd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: new Guid("43556f68-c541-42e6-a5c8-591225b3184d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: new Guid("ef79c68a-1b32-4f79-a46a-2e296b174d3a"));

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "NumberAvailable", "OrderId", "Price", "Summary", "Title" },
                values: new object[] { new Guid("de9bbf43-5286-4da2-b786-6d7943673a79"), "Antoine de Saint-Exupery", 15, null, 13.25m, "Written during World War II, The Little Prince tells of the friendship between the narrator, an aviator stranded in the Sahara desert, and a mysterious boy he encounters there. Ruler of a tiny asteroid of which he is the only inhabitant, the Little Prince chats disarmingly about his curious adventures in space and since arriving on earth; of his distant home; and of his love for a beautiful and capricious rose, to whom he longs to return. A moving and deceptively simple tale, it was described by Antoine de Saint-Exup???ry as a children's story for adults, and it works on several levels as an allegory of his own life and of the human condition. Children love it for its deadpan fantasy, for its sense of baffled amusement at the grown-up world, and for the author's whimsical watercolour illustrations, which are an integral part of the book.", "Le Petit Prince" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "NumberAvailable", "OrderId", "Price", "Summary", "Title" },
                values: new object[] { new Guid("cc08471b-b967-427e-90dc-552ef46704c6"), "Thomas Hobbes", 5, null, 23.50m, "Leviathan or The Matter, Forme and Power of a Common Wealth Ecclesiasticall and Civil-commonly referred to as Leviathan-is a book written by Thomas Hobbes (1588-1679) and published in 1651 (revised Latin edition 1668). Its name derives from the biblical Leviathan. The work concerns the structure of society and legitimate government, and is regarded as one of the earliest and most influential examples of social contract theory. Leviathan ranks as a classic western work on statecraft comparable to Machiavelli's The Prince. Written during the English Civil War (1642-1651), Leviathan argues for a social contract and rule by an absolute sovereign. Hobbes wrote that civil war and the brute situation of a state of nature (\"the war of all against all\") could only be avoided by strong, undivided government.", "Leviathan" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "NumberAvailable", "OrderId", "Price", "Summary", "Title" },
                values: new object[] { new Guid("8de8bf6f-dd08-46bd-b1ee-4f86f30d8627"), "Jacob and Wilhelm Grimm", 3, null, 19.25m, "The stories of magic and myth gathered by the Brothers Grimm have become part of the way children—and adults—learn about the vagaries of the real world. Cinderella, Rapunzel, Snow-White, Hänsel and Gretel, Little Red-Cap (Little Red Riding Hood), and Briar-Rose (Sleeping Beauty) are only a few of the more than two hundred enchanting characters included in this volume. The tales are presented just as Jacob and Wilhelm Grimm originally set them down: bold, primal, just frightening enough, and endlessly engaging.", "Grimm's Complete Fairy Tales" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: new Guid("8de8bf6f-dd08-46bd-b1ee-4f86f30d8627"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: new Guid("cc08471b-b967-427e-90dc-552ef46704c6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: new Guid("de9bbf43-5286-4da2-b786-6d7943673a79"));

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "NumberAvailable", "OrderId", "Price", "Summary", "Title" },
                values: new object[] { new Guid("0ee49a28-7699-4182-ae06-b105d7f1f8dd"), "Antoine de Saint-Exupery", 15, null, 13.25m, "Written during World War II, The Little Prince tells of the friendship between the narrator, an aviator stranded in the Sahara desert, and a mysterious boy he encounters there. Ruler of a tiny asteroid of which he is the only inhabitant, the Little Prince chats disarmingly about his curious adventures in space and since arriving on earth; of his distant home; and of his love for a beautiful and capricious rose, to whom he longs to return. A moving and deceptively simple tale, it was described by Antoine de Saint-Exup???ry as a children's story for adults, and it works on several levels as an allegory of his own life and of the human condition. Children love it for its deadpan fantasy, for its sense of baffled amusement at the grown-up world, and for the author's whimsical watercolour illustrations, which are an integral part of the book.", "Le Petit Prince" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "NumberAvailable", "OrderId", "Price", "Summary", "Title" },
                values: new object[] { new Guid("43556f68-c541-42e6-a5c8-591225b3184d"), "Thomas Hobbes", 5, null, 23.50m, "Leviathan or The Matter, Forme and Power of a Common Wealth Ecclesiasticall and Civil-commonly referred to as Leviathan-is a book written by Thomas Hobbes (1588-1679) and published in 1651 (revised Latin edition 1668). Its name derives from the biblical Leviathan. The work concerns the structure of society and legitimate government, and is regarded as one of the earliest and most influential examples of social contract theory. Leviathan ranks as a classic western work on statecraft comparable to Machiavelli's The Prince. Written during the English Civil War (1642-1651), Leviathan argues for a social contract and rule by an absolute sovereign. Hobbes wrote that civil war and the brute situation of a state of nature (\"the war of all against all\") could only be avoided by strong, undivided government.", "Leviathan" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "NumberAvailable", "OrderId", "Price", "Summary", "Title" },
                values: new object[] { new Guid("ef79c68a-1b32-4f79-a46a-2e296b174d3a"), "Jacob and Wilhelm Grimm", 3, null, 19.25m, "The stories of magic and myth gathered by the Brothers Grimm have become part of the way children—and adults—learn about the vagaries of the real world. Cinderella, Rapunzel, Snow-White, Hänsel and Gretel, Little Red-Cap (Little Red Riding Hood), and Briar-Rose (Sleeping Beauty) are only a few of the more than two hundred enchanting characters included in this volume. The tales are presented just as Jacob and Wilhelm Grimm originally set them down: bold, primal, just frightening enough, and endlessly engaging.", "Grimm's Complete Fairy Tales" });
        }
    }
}
