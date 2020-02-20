using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewWebsiteProject.Migrations
{
    public partial class RemovedReviewColumnFromProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Review",
                table: "Products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Review",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Review",
                value: "I bought this arcade game, now I hate ghosts!");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Review",
                value: "Wtf I love this game?");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Review",
                value: "Being inflated till you explode has got to hurt!");
        }
    }
}
