using AguaMariaSolution.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace AguaMariaSolution.Server.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Citas> Citas { get; set; }
        public DbSet<Colaboradores> Colaboradores { get; set; }
        public DbSet<CitasDetalles> CitasDetalles { get; set; }

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
        }
    }
}


