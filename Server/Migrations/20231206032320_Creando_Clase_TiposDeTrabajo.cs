using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AguaMariaSolution.Server.Migrations
{
    /// <inheritdoc />
    public partial class Creando_Clase_TiposDeTrabajo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Clave",
                table: "Colaboradores");

            migrationBuilder.AlterColumn<string>(
                name: "Teléfono",
                table: "Colaboradores",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "Colaboradores",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Clave",
                table: "Clientes",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Baneado",
                table: "Clientes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

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
                name: "TiposDeTrabajos",
                columns: table => new
                {
                    TipoDeTrabajoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false),
                    TiempoEstimado = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposDeTrabajos", x => x.TipoDeTrabajoId);
                    table.ForeignKey(
                        name: "FK_TiposDeTrabajos_Citas_TipoDeTrabajoId",
                        column: x => x.TipoDeTrabajoId,
                        principalTable: "Citas",
                        principalColumn: "CitaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TiposDeTrabajos_Colaboradores_TipoDeTrabajoId",
                        column: x => x.TipoDeTrabajoId,
                        principalTable: "Colaboradores",
                        principalColumn: "ColaboradorId",
                        onDelete: ReferentialAction.Cascade);
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
                table: "Empleados",
                columns: new[] { "EmpleadoId", "Apellido", "Celular", "Clave", "Dirección", "Email", "Nombre", "Teléfono" },
                values: new object[,]
                {
                    { 1, "Nose", "0123456789", "Cl@ve123", "Su casa", "Randy@magicmirror.com", "Randy", "0123456789" },
                    { 2, "Nose", "0123456789", "Cl@ve123", "Su casa", "Luis@magicmirror.com", "Luis", "0123456789" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "TiposDeTrabajos");

            migrationBuilder.DropColumn(
                name: "Activo",
                table: "Colaboradores");

            migrationBuilder.DropColumn(
                name: "Baneado",
                table: "Clientes");

            migrationBuilder.AlterColumn<string>(
                name: "Teléfono",
                table: "Colaboradores",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Clave",
                table: "Colaboradores",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Clave",
                table: "Clientes",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }
    }
}
