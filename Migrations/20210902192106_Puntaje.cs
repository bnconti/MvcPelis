using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcPelis.Migrations
{
    public partial class Puntaje : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Puntaje",
                table: "Pelicula",
                type: "decimal(2,0)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Puntaje",
                table: "Pelicula");
        }
    }
}
