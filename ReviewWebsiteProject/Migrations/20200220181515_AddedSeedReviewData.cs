using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewWebsiteProject.Migrations
{
    public partial class AddedSeedReviewData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ProductId" },
                values: new object[] { 1, "Tasty", 1 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ProductId" },
                values: new object[] { 2, "Not Tasty", 2 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ProductId" },
                values: new object[] { 3, "Tastiest", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");
        }
    }
}
