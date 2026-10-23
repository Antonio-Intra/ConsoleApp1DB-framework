using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp1DB_framework.Migrations
{
    /// <inheritdoc />
    public partial class Versaodois : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "valor",
                table: "aplicaçãofinanceiras",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "valor",
                table: "aplicaçãofinanceiras",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
