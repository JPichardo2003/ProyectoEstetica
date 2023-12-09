using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AguaMariaSolution.Server.Migrations
{
    /// <inheritdoc />
    public partial class prueba : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TiposDeTrabajos",
                keyColumn: "TipoDeTrabajoId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TiposDeTrabajos",
                keyColumn: "TipoDeTrabajoId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TiposDeTrabajos",
                keyColumn: "TipoDeTrabajoId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TiposDeTrabajos",
                keyColumn: "TipoDeTrabajoId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TiposDeTrabajos",
                keyColumn: "TipoDeTrabajoId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TiposDeTrabajos",
                keyColumn: "TipoDeTrabajoId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TiposDeTrabajos",
                keyColumn: "TipoDeTrabajoId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TiposDeTrabajos",
                keyColumn: "TipoDeTrabajoId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TiposDeTrabajos",
                keyColumn: "TipoDeTrabajoId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TiposDeTrabajos",
                keyColumn: "TipoDeTrabajoId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TiposDeTrabajos",
                keyColumn: "TipoDeTrabajoId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TiposDeTrabajos",
                keyColumn: "TipoDeTrabajoId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TiposDeTrabajos",
                keyColumn: "TipoDeTrabajoId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TiposDeTrabajos",
                keyColumn: "TipoDeTrabajoId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "TiposDeTrabajos",
                keyColumn: "TipoDeTrabajoId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "TiposDeTrabajos",
                keyColumn: "TipoDeTrabajoId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "TiposDeTrabajos",
                keyColumn: "TipoDeTrabajoId",
                keyValue: 27);

            migrationBuilder.UpdateData(
                table: "TiposDeTrabajos",
                keyColumn: "TipoDeTrabajoId",
                keyValue: 1,
                column: "Descripcion",
                value: "Limpieza");

            migrationBuilder.UpdateData(
                table: "TiposDeTrabajos",
                keyColumn: "TipoDeTrabajoId",
                keyValue: 6,
                column: "Descripcion",
                value: "Tratamiento");

            migrationBuilder.UpdateData(
                table: "TiposDeTrabajos",
                keyColumn: "TipoDeTrabajoId",
                keyValue: 7,
                columns: new[] { "Descripcion", "Precio", "TiempoEstimado" },
                values: new object[] { "Maquillaje", 1500f, 60 });

            migrationBuilder.UpdateData(
                table: "TiposDeTrabajos",
                keyColumn: "TipoDeTrabajoId",
                keyValue: 8,
                columns: new[] { "Descripcion", "Precio", "TiempoEstimado" },
                values: new object[] { "Tinte", 1000f, 45 });

            migrationBuilder.UpdateData(
                table: "TiposDeTrabajos",
                keyColumn: "TipoDeTrabajoId",
                keyValue: 9,
                columns: new[] { "Descripcion", "Precio", "TiempoEstimado" },
                values: new object[] { "Extensiones", 7000f, 30 });

            migrationBuilder.UpdateData(
                table: "TiposDeTrabajos",
                keyColumn: "TipoDeTrabajoId",
                keyValue: 10,
                columns: new[] { "Descripcion", "Precio", "TiempoEstimado" },
                values: new object[] { "Uñas", 1000f, 50 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TiposDeTrabajos",
                keyColumn: "TipoDeTrabajoId",
                keyValue: 1,
                column: "Descripcion",
                value: "Limpieza Facial");

            migrationBuilder.UpdateData(
                table: "TiposDeTrabajos",
                keyColumn: "TipoDeTrabajoId",
                keyValue: 6,
                column: "Descripcion",
                value: "Tratamiento Facial");

            migrationBuilder.UpdateData(
                table: "TiposDeTrabajos",
                keyColumn: "TipoDeTrabajoId",
                keyValue: 7,
                columns: new[] { "Descripcion", "Precio", "TiempoEstimado" },
                values: new object[] { "Tratamiento Corporal", 600f, 40 });

            migrationBuilder.UpdateData(
                table: "TiposDeTrabajos",
                keyColumn: "TipoDeTrabajoId",
                keyValue: 8,
                columns: new[] { "Descripcion", "Precio", "TiempoEstimado" },
                values: new object[] { "Tratamiento Capilar", 500f, 35 });

            migrationBuilder.UpdateData(
                table: "TiposDeTrabajos",
                keyColumn: "TipoDeTrabajoId",
                keyValue: 9,
                columns: new[] { "Descripcion", "Precio", "TiempoEstimado" },
                values: new object[] { "Maquillaje", 1500f, 60 });

            migrationBuilder.UpdateData(
                table: "TiposDeTrabajos",
                keyColumn: "TipoDeTrabajoId",
                keyValue: 10,
                columns: new[] { "Descripcion", "Precio", "TiempoEstimado" },
                values: new object[] { "Tinte de Pestañas", 700f, 45 });

            migrationBuilder.InsertData(
                table: "TiposDeTrabajos",
                columns: new[] { "TipoDeTrabajoId", "CitasCitaId", "ColaboradoresColaboradorId", "Descripcion", "Precio", "TiempoEstimado" },
                values: new object[,]
                {
                    { 11, null, null, "Tinte de Cejas", 400f, 45 },
                    { 12, null, null, "Micropigmentacion", 1000f, 70 },
                    { 13, null, null, "Extensiones de Pestañas", 600f, 30 },
                    { 14, null, null, "Extensiones de Cejas", 700f, 30 },
                    { 15, null, null, "Extensiones de Uñas", 700f, 30 },
                    { 16, null, null, "Uñas Acrilicas Para Manos", 1000f, 45 },
                    { 17, null, null, "Uñas Gelish Para Manos", 1100f, 50 },
                    { 18, null, null, "Uñas Esculpidas Para Manos", 1200f, 50 },
                    { 19, null, null, "Uñas Acrigel Para Manos", 1300f, 50 },
                    { 20, null, null, "Uñas Polygel Para Manos", 1200f, 40 },
                    { 21, null, null, "Uñas Acrilgel Para Manos", 1200f, 60 },
                    { 22, null, null, "Uñas Acrilicas Para Pies", 1000f, 50 },
                    { 23, null, null, "Uñas Gelish Para Pies", 1100f, 50 },
                    { 24, null, null, "Uñas Esculpidas Para Pies", 1200f, 50 },
                    { 25, null, null, "Uñas Acrigel Para Pies", 1300f, 40 },
                    { 26, null, null, "Uñas Polygel Para Pies", 1200f, 60 },
                    { 27, null, null, "Uñas Acrilgel Para Pies", 1200f, 50 }
                });
        }
    }
}
