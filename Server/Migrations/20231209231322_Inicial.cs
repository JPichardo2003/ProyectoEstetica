using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AguaMariaSolution.Server.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Apellido = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Contraseña = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Apellido = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Clave = table.Column<string>(type: "TEXT", nullable: false),
                    Teléfono = table.Column<string>(type: "TEXT", nullable: false),
                    Baneado = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                });

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
                    Teléfono = table.Column<string>(type: "TEXT", nullable: true),
                    Celular = table.Column<string>(type: "TEXT", nullable: false),
                    Activo = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colaboradores", x => x.ColaboradorId);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    EmpleadoId = table.Column<int>(type: "INTEGER", nullable: false)
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
                    table.PrimaryKey("PK_Empleados", x => x.EmpleadoId);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Descripción = table.Column<string>(type: "TEXT", nullable: true),
                    Existencia = table.Column<float>(type: "REAL", nullable: false),
                    Precio = table.Column<float>(type: "REAL", nullable: false),
                    Imagen = table.Column<byte[]>(type: "BLOB", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.ProductoId);
                });

            migrationBuilder.CreateTable(
                name: "Citas",
                columns: table => new
                {
                    CitaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: false),
                    ColaboradorId = table.Column<int>(type: "INTEGER", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Asunto = table.Column<string>(type: "TEXT", nullable: false),
                    Monto = table.Column<float>(type: "REAL", nullable: false),
                    Llego = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citas", x => x.CitaId);
                    table.ForeignKey(
                        name: "FK_Citas_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Citas_Colaboradores_ColaboradorId",
                        column: x => x.ColaboradorId,
                        principalTable: "Colaboradores",
                        principalColumn: "ColaboradorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CitasDetalles",
                columns: table => new
                {
                    DetalleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CitaId = table.Column<int>(type: "INTEGER", nullable: false),
                    CantidadUtilizada = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CitasDetalles", x => x.DetalleId);
                    table.ForeignKey(
                        name: "FK_CitasDetalles_Citas_CitaId",
                        column: x => x.CitaId,
                        principalTable: "Citas",
                        principalColumn: "CitaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TiposDeTrabajos",
                columns: table => new
                {
                    TipoDeTrabajoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false),
                    TiempoEstimado = table.Column<int>(type: "INTEGER", nullable: false),
                    Precio = table.Column<float>(type: "REAL", nullable: false),
                    CitasCitaId = table.Column<int>(type: "INTEGER", nullable: true),
                    ColaboradoresColaboradorId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposDeTrabajos", x => x.TipoDeTrabajoId);
                    table.ForeignKey(
                        name: "FK_TiposDeTrabajos_Citas_CitasCitaId",
                        column: x => x.CitasCitaId,
                        principalTable: "Citas",
                        principalColumn: "CitaId");
                    table.ForeignKey(
                        name: "FK_TiposDeTrabajos_Colaboradores_ColaboradoresColaboradorId",
                        column: x => x.ColaboradoresColaboradorId,
                        principalTable: "Colaboradores",
                        principalColumn: "ColaboradorId");
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "AdminId", "Apellido", "Contraseña", "Email", "Nombre" },
                values: new object[,]
                {
                    { 1, "El Hage Jreij", "Cl@ve123", "abrahamehj@magicmirror.com", "Abraham" },
                    { 2, "Pichardo Barranco", "Cl@ve123", "juliocpb@magicmirror.com", "Julio Cesar" }
                });

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

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "EmpleadoId", "Apellido", "Celular", "Clave", "Dirección", "Email", "Nombre", "Teléfono" },
                values: new object[,]
                {
                    { 1, "Nose", "0123456789", "Cl@ve123", "Su casa", "Randy@magicmirror.com", "Randy", "0123456789" },
                    { 2, "Nose", "0123456789", "Cl@ve123", "Su casa", "Luis@magicmirror.com", "Luis", "0123456789" }
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "Descripción", "Existencia", "Imagen", "Nombre", "Precio" },
                values: new object[,]
                {
                    { 1, "Control de Acne", 40f, null, "ProActiv Solution", 100f },
                    { 2, "Combatir la resequeda", 60f, null, "Moisturizer Cerave", 100f },
                    { 3, "Elimina la Grasa", 50f, null, "Eucerin", 100f },
                    { 4, "Suero Purificador de pestañas", 70f, null, "Lilash", 100f },
                    { 5, "Pestañas Magneticas", 10f, null, "Luxillia", 100f },
                    { 6, "Exfoliante quimico para el rostro", 30f, null, "The ordinary exofoliante", 100f },
                    { 7, "Set Fijador de Cejas", 0f, null, "Brows lamination kit", 100f }
                });

            migrationBuilder.InsertData(
                table: "TiposDeTrabajos",
                columns: new[] { "TipoDeTrabajoId", "CitasCitaId", "ColaboradoresColaboradorId", "Descripcion", "Precio", "TiempoEstimado" },
                values: new object[,]
                {
                    { 1, null, null, "Limpieza", 300f, 20 },
                    { 2, null, null, "Manicura", 400f, 40 },
                    { 3, null, null, "Pedicura", 400f, 40 },
                    { 4, null, null, "Masaje", 700f, 60 },
                    { 5, null, null, "Depilacion", 500f, 40 },
                    { 6, null, null, "Tratamiento", 500f, 35 },
                    { 7, null, null, "Maquillaje", 1500f, 60 },
                    { 8, null, null, "Tinte", 1000f, 45 },
                    { 9, null, null, "Extensiones", 7000f, 30 },
                    { 10, null, null, "Uñas", 1000f, 50 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Citas_ClienteId",
                table: "Citas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_ColaboradorId",
                table: "Citas",
                column: "ColaboradorId");

            migrationBuilder.CreateIndex(
                name: "IX_CitasDetalles_CitaId",
                table: "CitasDetalles",
                column: "CitaId");

            migrationBuilder.CreateIndex(
                name: "IX_TiposDeTrabajos_CitasCitaId",
                table: "TiposDeTrabajos",
                column: "CitasCitaId");

            migrationBuilder.CreateIndex(
                name: "IX_TiposDeTrabajos_ColaboradoresColaboradorId",
                table: "TiposDeTrabajos",
                column: "ColaboradoresColaboradorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "CitasDetalles");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "TiposDeTrabajos");

            migrationBuilder.DropTable(
                name: "Citas");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Colaboradores");
        }
    }
}
