using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AguaMariaSolution.Server.Migrations
{
    /// <inheritdoc />
    public partial class Inicial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Teléfono",
                table: "Clientes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ColaboradorId",
                table: "Citas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Colaboradores",
                columns: table => new
                {
                    ColaboradorId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Apellido = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Dirección = table.Column<string>(type: "TEXT", nullable: false),
                    Clave = table.Column<string>(type: "TEXT", nullable: false),
                    Teléfono = table.Column<string>(type: "TEXT", nullable: false),
                    Celular = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colaboradores", x => x.ColaboradorId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Citas_ColaboradorId",
                table: "Citas",
                column: "ColaboradorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Colaboradores_ColaboradorId",
                table: "Citas",
                column: "ColaboradorId",
                principalTable: "Colaboradores",
                principalColumn: "ColaboradorId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Colaboradores_ColaboradorId",
                table: "Citas");

            migrationBuilder.DropTable(
                name: "Colaboradores");

            migrationBuilder.DropIndex(
                name: "IX_Citas_ColaboradorId",
                table: "Citas");

            migrationBuilder.DropColumn(
                name: "Teléfono",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "ColaboradorId",
                table: "Citas");
        }
    }
}
