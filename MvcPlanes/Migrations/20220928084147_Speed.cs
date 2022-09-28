using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcPlanes.Migrations
{
    public partial class Speed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Speed",
                table: "Plane",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Speed",
                table: "Plane");
        }
    }
}
