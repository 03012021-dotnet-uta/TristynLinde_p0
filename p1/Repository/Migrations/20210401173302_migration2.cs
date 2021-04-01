using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: new Guid("42910abd-85ca-40df-8dfb-043553b26941"));

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "NumberAvailable", "OrderId", "Price", "Summary", "Title" },
                values: new object[] { new Guid("ea136960-5276-4e1d-90d9-e98bc5f9357a"), "Antoine de Saint-Exupery", 15, null, 13.25m, "Written during World War II, The Little Prince tells of the friendship between the narrator, an aviator stranded in the Sahara desert, and a mysterious boy he encounters there. Ruler of a tiny asteroid of which he is the only inhabitant, the Little Prince chats disarmingly about his curious adventures in space and since arriving on earth; of his distant home; and of his love for a beautiful and capricious rose, to whom he longs to return. A moving and deceptively simple tale, it was described by Antoine de Saint-Exup???ry as a children's story for adults, and it works on several levels as an allegory of his own life and of the human condition. Children love it for its deadpan fantasy, for its sense of baffled amusement at the grown-up world, and for the author's whimsical watercolour illustrations, which are an integral part of the book.", "Le Petit Prince" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "NumberAvailable", "OrderId", "Price", "Summary", "Title" },
                values: new object[] { new Guid("d1884a1b-4b07-449a-8081-61faf558abe6"), "Thomas Hobbes", 5, null, 23.50m, "Leviathan or The Matter, Forme and Power of a Common Wealth Ecclesiasticall and Civil-commonly referred to as Leviathan-is a book written by Thomas Hobbes (1588-1679) and published in 1651 (revised Latin edition 1668). Its name derives from the biblical Leviathan. The work concerns the structure of society and legitimate government, and is regarded as one of the earliest and most influential examples of social contract theory. Leviathan ranks as a classic western work on statecraft comparable to Machiavelli's The Prince. Written during the English Civil War (1642-1651), Leviathan argues for a social contract and rule by an absolute sovereign. Hobbes wrote that civil war and the brute situation of a state of nature (\"the war of all against all\") could only be avoided by strong, undivided government.", "Leviathan" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "NumberAvailable", "OrderId", "Price", "Summary", "Title" },
                values: new object[] { new Guid("ca6941b3-c315-4476-b90f-e19e1a086d9d"), "Jacob and Wilhelm Grimm", 3, null, 19.25m, "The stories of magic and myth gathered by the Brothers Grimm have become part of the way children—and adults—learn about the vagaries of the real world. Cinderella, Rapunzel, Snow-White, Hänsel and Gretel, Little Red-Cap (Little Red Riding Hood), and Briar-Rose (Sleeping Beauty) are only a few of the more than two hundred enchanting characters included in this volume. The tales are presented just as Jacob and Wilhelm Grimm originally set them down: bold, primal, just frightening enough, and endlessly engaging.", "Grimm's Complete Fairy Tales" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: new Guid("ca6941b3-c315-4476-b90f-e19e1a086d9d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: new Guid("d1884a1b-4b07-449a-8081-61faf558abe6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: new Guid("ea136960-5276-4e1d-90d9-e98bc5f9357a"));

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "NumberAvailable", "OrderId", "Price", "Summary", "Title" },
                values: new object[] { new Guid("42910abd-85ca-40df-8dfb-043553b26941"), "Antoine de Saint-Exupery", 15, null, 10m, "Le Petit Prince is Saint-Exupéry's most successful work, and has sold an estimated 140 million copies worldwide, making it one of the best-selling and most translated books ever published. The story follows a young prince who visits various planets in space, including Earth, and addresses themes of loneliness, friendship, love, and loss. Despite its style as a children's book, Le Petit Prince makes observations about life and human nature.", "Le Petit Prince" });
        }
    }
}
