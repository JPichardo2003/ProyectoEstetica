using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AguaMariaSolution.Server.Migrations
{
    /// <inheritdoc />
    public partial class Modificando_Clase_TiposDeTrabajo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Precio",
                table: "TiposDeTrabajos",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<bool>(
                name: "Llego",
                table: "Citas",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "TiposDeTrabajos",
                columns: new[] { "TipoDeTrabajoId", "Descripcion", "Precio", "TiempoEstimado" },
                values: new object[,]
                {
                    { 1, "Limpieza Facial", 300f, 20 },
                    { 2, "Manicura", 400f, 40 },
                    { 3, "Pedicura", 400f, 40 },
                    { 4, "Masaje", 700f, 60 },
                    { 5, "Depilacion", 500f, 40 },
                    { 6, "Tratamiento Facial", 500f, 35 },
                    { 7, "Tratamiento Corporal", 600f, 40 },
                    { 8, "Tratamiento Capilar", 500f, 35 },
                    { 9, "Maquillaje", 1500f, 60 },
                    { 10, "Tinte de Pestañas", 700f, 45 },
                    { 11, "Tinte de Cejas", 400f, 45 },
                    { 12, "Micropigmentacion", 1000f, 70 },
                    { 13, "Extensiones de Pestañas", 600f, 30 },
                    { 14, "Extensiones de Cejas", 700f, 30 },
                    { 15, "Extensiones de Uñas", 700f, 30 },
                    { 16, "Uñas Acrilicas Para Manos", 1000f, 45 },
                    { 17, "Uñas Gelish Para Manos", 1100f, 50 },
                    { 18, "Uñas Esculpidas Para Manos", 1200f, 50 },
                    { 19, "Uñas Acrigel Para Manos", 1300f, 50 },
                    { 20, "Uñas Polygel Para Manos", 1200f, 40 },
                    { 21, "Uñas Acrilgel Para Manos", 1200f, 60 },
                    { 22, "Uñas Acrilicas Para Pies", 1000f, 50 },
                    { 23, "Uñas Gelish Para Pies", 1100f, 50 },
                    { 24, "Uñas Esculpidas Para Pies", 1200f, 50 },
                    { 25, "Uñas Acrigel Para Pies", 1300f, 40 },
                    { 26, "Uñas Polygel Para Pies", 1200f, 60 },
                    { 27, "Uñas Acrilgel Para Pies", 1200f, 50 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TiposDeTrabajos",
                keyColumn: "TipoDeTrabajoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TiposDeTrabajos",
                keyColumn: "TipoDeTrabajoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TiposDeTrabajos",
                keyColumn: "TipoDeTrabajoId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TiposDeTrabajos",
                keyColumn: "TipoDeTrabajoId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TiposDeTrabajos",
                keyColumn: "TipoDeTrabajoId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TiposDeTrabajos",
                keyColumn: "TipoDeTrabajoId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TiposDeTrabajos",
                keyColumn: "TipoDeTrabajoId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TiposDeTrabajos",
                keyColumn: "TipoDeTrabajoId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TiposDeTrabajos",
                keyColumn: "TipoDeTrabajoId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TiposDeTrabajos",
                keyColumn: "TipoDeTrabajoId",
                keyValue: 10);

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

            migrationBuilder.DropColumn(
                name: "Precio",
                table: "TiposDeTrabajos");

            migrationBuilder.DropColumn(
                name: "Llego",
                table: "Citas");
        }
    }
}
