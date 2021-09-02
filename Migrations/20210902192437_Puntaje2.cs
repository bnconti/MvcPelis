using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcPelis.Migrations
{
    public partial class Puntaje2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Puntaje",
                table: "Pelicula",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(2,0)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Puntaje",
                table: "Pelicula",
                type: "decimal(2,0)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
