using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewWebsiteProject.Migrations
{
    public partial class SecondProductMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Image", "Name", "Review" },
                values: new object[] { "Yellow fruit-eating monster", "/img/pacman.jpg", "Pac-Man", "I bought this arcade game, now I hate ghosts!" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Name", "Review" },
                values: new object[] { 3, "Dig and dug", "/img/digdug.jpg", "DigDug", "Being inflated till you explode has got to hurt!" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Name", "Review" },
                values: new object[] { 2, "Save the Realms from certain doom", "/img/GauntletLegends.jpg", "Gauntlet Legends", "Wtf I love this game?" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Image", "Name", "Review" },
                values: new object[] { "fruit-eating monster", "/img/GauntletLegends.jpg", "Yellow", "I bought this arcade game, now I hate ghosts" });
        }
    }
}
