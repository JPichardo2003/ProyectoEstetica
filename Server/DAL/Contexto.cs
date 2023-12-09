using AguaMariaSolution.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace AguaMariaSolution.Server.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Admins> Admins { get; set; }
        public DbSet<Empleados> Empleados { get; set; }
        public DbSet<Citas> Citas { get; set; }
        public DbSet<Colaboradores> Colaboradores { get; set; }
        public DbSet<CitasDetalles> CitasDetalles { get; set; }

        public DbSet<TiposDeTrabajos> TiposDeTrabajos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Productos>().HasData(new List<Productos>()
            {
                new Productos(){ProductoId=1,Nombre = "ProActiv Solution", Descripción="Control de Acne", Existencia = 40, Precio = 100},
                new Productos(){ProductoId=2,Nombre = "Moisturizer Cerave", Descripción= "Combatir la resequeda", Existencia = 60, Precio = 100},
                new Productos(){ProductoId=3,Nombre = "Eucerin", Descripción="Elimina la Grasa", Existencia = 50, Precio = 100},
                new Productos(){ProductoId=4,Nombre = "Lilash", Descripción="Suero Purificador de pestañas", Existencia = 70, Precio = 100},
                new Productos(){ProductoId=5,Nombre = "Luxillia", Descripción="Pestañas Magneticas", Existencia = 10, Precio = 100},
                new Productos(){ProductoId=6,Nombre = "The ordinary exofoliante", Descripción="Exfoliante quimico para el rostro", Existencia = 30, Precio = 100},
                new Productos(){ProductoId=7,Nombre = "Brows lamination kit", Descripción="Set Fijador de Cejas", Existencia = 0, Precio = 100}
            });

            modelBuilder.Entity<Admins>().HasData(new List<Admins>()
            {
                new Admins() {AdminId = 1, Nombre = "Abraham", Apellido="El Hage Jreij", Email="abrahamehj@magicmirror.com", Contraseña = "Cl@ve123"},
                new Admins() {AdminId = 2, Nombre = "Julio Cesar", Apellido="Pichardo Barranco",Email="juliocpb@magicmirror.com", Contraseña = "Cl@ve123"}
            });

            modelBuilder.Entity<Empleados>().HasData(new List<Empleados>()
            {
                new Empleados() {EmpleadoId = 1, Nombre = "Randy", Apellido="Nose", Email="Randy@magicmirror.com", Clave="Cl@ve123", Celular="0123456789", Teléfono="0123456789", Dirección="Su casa"},
                new Empleados() {EmpleadoId = 2, Nombre = "Luis", Apellido="Nose", Email="Luis@magicmirror.com", Clave="Cl@ve123", Celular="0123456789", Teléfono="0123456789", Dirección="Su casa"}
            });

            modelBuilder.Entity<Clientes>().HasData(new List<Clientes>
            {
                new Clientes
                {
                    ClienteId = 1,
                    Nombre = "John",
                    Apellido = "Doe",
                    Email = "john.doe@example.com",
                    Clave = "Password123",
                    Teléfono = "1234567890",
                    // Add other properties
                },
                new Clientes
                {
                    ClienteId = 2,
                    Nombre = "Jane",
                    Apellido = "Doe",
                    Email = "jane.doe@example.com",
                    Clave = "Password456",
                    Teléfono = "9876543210",
                    // Add other properties
                },
                // Add more client data as needed
            });

                        modelBuilder.Entity<Colaboradores>().HasData(new List<Colaboradores>
            {
                new Colaboradores
                {
                    ColaboradorId = 1,
                    Nombre = "Employee1",
                    Apellido = "Lastname1",
                    Email = "employee1@example.com",
                    Dirección = "Employee1 Address",
                    Teléfono = "1112223333",
                    Celular = "4445556666",
                    // Add other properties
                },
                new Colaboradores
                {
                    ColaboradorId = 2,
                    Nombre = "Employee2",
                    Apellido = "Lastname2",
                    Email = "employee2@example.com",
                    Dirección = "Employee2 Address",
                    Teléfono = "7778889999",
                    Celular = "0001112222",
                    // Add other properties
                },
                // Add more collaborator data as needed
            });

            modelBuilder.Entity<TiposDeTrabajos>().HasData(new List<TiposDeTrabajos>()
            {
                new TiposDeTrabajos()  {TipoDeTrabajoId = 1, Precio = 500, TiempoEstimado = 20, Descripcion = "Limpieza"},
                new TiposDeTrabajos()  {TipoDeTrabajoId = 2, TiempoEstimado = 40, Descripcion = "Manicura", Precio = 500},
                new TiposDeTrabajos()  {TipoDeTrabajoId = 3, TiempoEstimado = 40, Descripcion = "Pedicura", Precio = 500},
                new TiposDeTrabajos()  {TipoDeTrabajoId = 4, TiempoEstimado = 60, Descripcion = "Masaje", Precio = 700},
                new TiposDeTrabajos()  {TipoDeTrabajoId = 5, TiempoEstimado = 40, Descripcion = "Depilacion", Precio = 500},
                new TiposDeTrabajos()  {TipoDeTrabajoId = 6, TiempoEstimado = 35, Descripcion = "Tratamiento", Precio = 900},
                new TiposDeTrabajos()  {TipoDeTrabajoId = 7, TiempoEstimado = 60, Descripcion = "Maquillaje", Precio = 1500},
                new TiposDeTrabajos()  {TipoDeTrabajoId = 8, TiempoEstimado = 45, Descripcion = "Tinte", Precio = 1000},
                new TiposDeTrabajos()  {TipoDeTrabajoId = 9, TiempoEstimado = 70, Descripcion = "Micropigmentacion", Precio = 1000},
                new TiposDeTrabajos()  {TipoDeTrabajoId = 10, TiempoEstimado = 30, Descripcion = "Extensiones", Precio = 1000},
                
            });
        }
    }
}


