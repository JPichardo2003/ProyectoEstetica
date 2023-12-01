using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AguaMariaSolution.Server.Migrations
{
    /// <inheritdoc />
    public partial class PruebaFoto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Imagen",
                table: "Productos",
                type: "BLOB",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 1,
                column: "Imagen",
                value: null);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 2,
                column: "Imagen",
                value: null);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 3,
                column: "Imagen",
                value: null);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 4,
                column: "Imagen",
                value: null);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 5,
                column: "Imagen",
                value: null);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 6,
                column: "Imagen",
                value: null);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 7,
                column: "Imagen",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagen",
                table: "Productos");
        }
    }
}
