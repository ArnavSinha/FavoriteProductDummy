using Microsoft.EntityFrameworkCore.Migrations;

namespace FavoriteProducts.Migrations
{
    public partial class secondmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductPrice",
                table: "ProductBases");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductPrice",
                table: "ProductBases",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
