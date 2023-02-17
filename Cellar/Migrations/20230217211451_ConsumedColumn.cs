using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cellar.Migrations
{
    public partial class ConsumedColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Consumed",
                table: "Wines",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Consumed",
                table: "Wines");
        }
    }
}
