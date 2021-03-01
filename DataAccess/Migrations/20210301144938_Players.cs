using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class Players : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MyProperty",
                table: "MyProperty");

            migrationBuilder.RenameTable(
                name: "MyProperty",
                newName: "Players");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Players",
                table: "Players",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Players",
                table: "Players");

            migrationBuilder.RenameTable(
                name: "Players",
                newName: "MyProperty");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyProperty",
                table: "MyProperty",
                column: "ID");
        }
    }
}
