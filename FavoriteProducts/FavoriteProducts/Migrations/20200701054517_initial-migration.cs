using Microsoft.EntityFrameworkCore.Migrations;

namespace FavoriteProducts.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductBases",
                columns: table => new
                {
                    PID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductNum = table.Column<string>(type: "varchar(50)", nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    ProductType = table.Column<string>(type: "varchar(50)", nullable: true),
                    ProductPrice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductBases", x => x.PID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductBases");
        }
    }
}
