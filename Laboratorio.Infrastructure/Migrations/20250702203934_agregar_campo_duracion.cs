using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Laboratorio.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class agregar_campo_duracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Duracion",
                table: "Videos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duracion",
                table: "Videos");
        }
    }
}
