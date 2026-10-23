using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp1DB_framework.Migrations
{
    /// <inheritdoc />
    public partial class VersaoInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "aplicaçãofinanceiras",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsFinalizado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aplicaçãofinanceiras", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "aplicaçãofinanceiras");
        }
    }
}
