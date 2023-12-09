using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AguaMariaSolution.Server.Migrations
{
    /// <inheritdoc />
    public partial class addcliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "ClienteId", "Apellido", "Baneado", "Clave", "Email", "Nombre", "Teléfono" },
                values: new object[,]
                {
                    { 1, "Doe", false, "Password123", "john.doe@example.com", "John", "1234567890" },
                    { 2, "Doe", false, "Password456", "jane.doe@example.com", "Jane", "9876543210" }
                });

            migrationBuilder.InsertData(
                table: "Colaboradores",
                columns: new[] { "ColaboradorId", "Activo", "Apellido", "Celular", "Dirección", "Email", "Nombre", "Teléfono" },
                values: new object[,]
                {
                    { 1, true, "Lastname1", "4445556666", "Employee1 Address", "employee1@example.com", "Employee1", "1112223333" },
                    { 2, true, "Lastname2", "0001112222", "Employee2 Address", "employee2@example.com", "Employee2", "7778889999" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Colaboradores",
                keyColumn: "ColaboradorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colaboradores",
                keyColumn: "ColaboradorId",
                keyValue: 2);
        }
    }
}
