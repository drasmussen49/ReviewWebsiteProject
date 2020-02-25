using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewWebsiteProject.Migrations
{
    public partial class AddedMoreSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "Content",
                value: "I Love this game. I feel like I can now conquer the world. But i'm still scared of ghosts.");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Content", "ProductId" },
                values: new object[] { "These pac-man are so cute!!. I wondered though if they'll ever get full.", 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Content", "ProductId" },
                values: new object[] { "This game really brought me back to my past life as a medieval serf taking over my fiefdom! ", 2 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ProductId" },
                values: new object[,]
                {
                    { 4, "Beware of this game. You will have nightmares for the next year. Play this game with caution.", 2 },
                    { 5, "This game just makes me want to sing, \"Digdug, digidigidug, digdug, digidigidug.\"", 3 },
                    { 6, "This game has inspired me to dig to China. I really think I can make it.", 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "Content",
                value: "Tasty");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Content", "ProductId" },
                values: new object[] { "Not Tasty", 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Content", "ProductId" },
                values: new object[] { "Tastiest", 1 });
        }
    }
}
