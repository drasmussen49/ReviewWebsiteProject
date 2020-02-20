using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewWebsiteProject.Migrations
{
    public partial class FirstProductMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Review = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Name", "Review" },
                values: new object[] { 1, "fruit-eating monster", "/img/GauntletLegends.jpg", "Yellow", "I bought this arcade game, now I hate ghosts" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
