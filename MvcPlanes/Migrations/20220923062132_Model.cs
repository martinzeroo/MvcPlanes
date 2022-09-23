using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcPlanes.Migrations
{
    public partial class Model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Plane",
                newName: "Model");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Model",
                table: "Plane",
                newName: "Type");
        }
    }
}
