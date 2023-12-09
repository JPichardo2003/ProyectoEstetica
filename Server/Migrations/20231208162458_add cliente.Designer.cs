﻿// <auto-generated />
using System;
using AguaMariaSolution.Server.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AguaMariaSolution.Server.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20231208162458_add cliente")]
    partial class addcliente
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("AguaMariaSolution.Shared.Models.Admins", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AdminId");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            AdminId = 1,
                            Apellido = "El Hage Jreij",
                            Contraseña = "Cl@ve123",
                            Email = "abrahamehj@magicmirror.com",
                            Nombre = "Abraham"
                        },
                        new
                        {
                            AdminId = 2,
                            Apellido = "Pichardo Barranco",
                            Contraseña = "Cl@ve123",
                            Email = "juliocpb@magicmirror.com",
                            Nombre = "Julio Cesar"
                        });
                });

            modelBuilder.Entity("AguaMariaSolution.Shared.Models.Citas", b =>
                {
                    b.Property<int>("CitaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Asunto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ColaboradorId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Llego")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Monto")
                        .HasColumnType("REAL");

                    b.HasKey("CitaId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("ColaboradorId");

                    b.ToTable("Citas");
                });

            modelBuilder.Entity("AguaMariaSolution.Shared.Models.CitasDetalles", b =>
                {
                    b.Property<int>("DetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CantidadUtilizada")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CitaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("DetalleId");

                    b.HasIndex("CitaId");

                    b.ToTable("CitasDetalles");
                });

            modelBuilder.Entity("AguaMariaSolution.Shared.Models.Clientes", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Baneado")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Teléfono")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ClienteId");

                    b.ToTable("Clientes");

                    b.HasData(
                        new
                        {
                            ClienteId = 1,
                            Apellido = "Doe",
                            Baneado = false,
                            Clave = "Password123",
                            Email = "john.doe@example.com",
                            Nombre = "John",
                            Teléfono = "1234567890"
                        },
                        new
                        {
                            ClienteId = 2,
                            Apellido = "Doe",
                            Baneado = false,
                            Clave = "Password456",
                            Email = "jane.doe@example.com",
                            Nombre = "Jane",
                            Teléfono = "9876543210"
                        });
                });

            modelBuilder.Entity("AguaMariaSolution.Shared.Models.Colaboradores", b =>
                {
                    b.Property<int>("ColaboradorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Activo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Dirección")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Teléfono")
                        .HasColumnType("TEXT");

                    b.HasKey("ColaboradorId");

                    b.ToTable("Colaboradores");

                    b.HasData(
                        new
                        {
                            ColaboradorId = 1,
                            Activo = true,
                            Apellido = "Lastname1",
                            Celular = "4445556666",
                            Dirección = "Employee1 Address",
                            Email = "employee1@example.com",
                            Nombre = "Employee1",
                            Teléfono = "1112223333"
                        },
                        new
                        {
                            ColaboradorId = 2,
                            Activo = true,
                            Apellido = "Lastname2",
                            Celular = "0001112222",
                            Dirección = "Employee2 Address",
                            Email = "employee2@example.com",
                            Nombre = "Employee2",
                            Teléfono = "7778889999"
                        });
                });

            modelBuilder.Entity("AguaMariaSolution.Shared.Models.Empleados", b =>
                {
                    b.Property<int>("EmpleadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Dirección")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Teléfono")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("EmpleadoId");

                    b.ToTable("Empleados");

                    b.HasData(
                        new
                        {
                            EmpleadoId = 1,
                            Apellido = "Nose",
                            Celular = "0123456789",
                            Clave = "Cl@ve123",
                            Dirección = "Su casa",
                            Email = "Randy@magicmirror.com",
                            Nombre = "Randy",
                            Teléfono = "0123456789"
                        },
                        new
                        {
                            EmpleadoId = 2,
                            Apellido = "Nose",
                            Celular = "0123456789",
                            Clave = "Cl@ve123",
                            Dirección = "Su casa",
                            Email = "Luis@magicmirror.com",
                            Nombre = "Luis",
                            Teléfono = "0123456789"
                        });
                });

            modelBuilder.Entity("AguaMariaSolution.Shared.Models.Productos", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripción")
                        .HasColumnType("TEXT");

                    b.Property<float>("Existencia")
                        .HasColumnType("REAL");

                    b.Property<byte[]>("Imagen")
                        .HasColumnType("BLOB");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<float>("Precio")
                        .HasColumnType("REAL");

                    b.HasKey("ProductoId");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            ProductoId = 1,
                            Descripción = "Control de Acne",
                            Existencia = 40f,
                            Nombre = "ProActiv Solution",
                            Precio = 100f
                        },
                        new
                        {
                            ProductoId = 2,
                            Descripción = "Combatir la resequeda",
                            Existencia = 60f,
                            Nombre = "Moisturizer Cerave",
                            Precio = 100f
                        },
                        new
                        {
                            ProductoId = 3,
                            Descripción = "Elimina la Grasa",
                            Existencia = 50f,
                            Nombre = "Eucerin",
                            Precio = 100f
                        },
                        new
                        {
                            ProductoId = 4,
                            Descripción = "Suero Purificador de pestañas",
                            Existencia = 70f,
                            Nombre = "Lilash",
                            Precio = 100f
                        },
                        new
                        {
                            ProductoId = 5,
                            Descripción = "Pestañas Magneticas",
                            Existencia = 10f,
                            Nombre = "Luxillia",
                            Precio = 100f
                        },
                        new
                        {
                            ProductoId = 6,
                            Descripción = "Exfoliante quimico para el rostro",
                            Existencia = 30f,
                            Nombre = "The ordinary exofoliante",
                            Precio = 100f
                        },
                        new
                        {
                            ProductoId = 7,
                            Descripción = "Set Fijador de Cejas",
                            Existencia = 0f,
                            Nombre = "Brows lamination kit",
                            Precio = 100f
                        });
                });

            modelBuilder.Entity("AguaMariaSolution.Shared.Models.TiposDeTrabajos", b =>
                {
                    b.Property<int>("TipoDeTrabajoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CitasCitaId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ColaboradoresColaboradorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Precio")
                        .HasColumnType("REAL");

                    b.Property<int>("TiempoEstimado")
                        .HasColumnType("INTEGER");

                    b.HasKey("TipoDeTrabajoId");

                    b.HasIndex("CitasCitaId");

                    b.HasIndex("ColaboradoresColaboradorId");

                    b.ToTable("TiposDeTrabajos");

                    b.HasData(
                        new
                        {
                            TipoDeTrabajoId = 1,
                            Descripcion = "Limpieza Facial",
                            Precio = 300f,
                            TiempoEstimado = 20
                        },
                        new
                        {
                            TipoDeTrabajoId = 2,
                            Descripcion = "Manicura",
                            Precio = 400f,
                            TiempoEstimado = 40
                        },
                        new
                        {
                            TipoDeTrabajoId = 3,
                            Descripcion = "Pedicura",
                            Precio = 400f,
                            TiempoEstimado = 40
                        },
                        new
                        {
                            TipoDeTrabajoId = 4,
                            Descripcion = "Masaje",
                            Precio = 700f,
                            TiempoEstimado = 60
                        },
                        new
                        {
                            TipoDeTrabajoId = 5,
                            Descripcion = "Depilacion",
                            Precio = 500f,
                            TiempoEstimado = 40
                        },
                        new
                        {
                            TipoDeTrabajoId = 6,
                            Descripcion = "Tratamiento Facial",
                            Precio = 500f,
                            TiempoEstimado = 35
                        },
                        new
                        {
                            TipoDeTrabajoId = 7,
                            Descripcion = "Tratamiento Corporal",
                            Precio = 600f,
                            TiempoEstimado = 40
                        },
                        new
                        {
                            TipoDeTrabajoId = 8,
                            Descripcion = "Tratamiento Capilar",
                            Precio = 500f,
                            TiempoEstimado = 35
                        },
                        new
                        {
                            TipoDeTrabajoId = 9,
                            Descripcion = "Maquillaje",
                            Precio = 1500f,
                            TiempoEstimado = 60
                        },
                        new
                        {
                            TipoDeTrabajoId = 10,
                            Descripcion = "Tinte de Pestañas",
                            Precio = 700f,
                            TiempoEstimado = 45
                        },
                        new
                        {
                            TipoDeTrabajoId = 11,
                            Descripcion = "Tinte de Cejas",
                            Precio = 400f,
                            TiempoEstimado = 45
                        },
                        new
                        {
                            TipoDeTrabajoId = 12,
                            Descripcion = "Micropigmentacion",
                            Precio = 1000f,
                            TiempoEstimado = 70
                        },
                        new
                        {
                            TipoDeTrabajoId = 13,
                            Descripcion = "Extensiones de Pestañas",
                            Precio = 600f,
                            TiempoEstimado = 30
                        },
                        new
                        {
                            TipoDeTrabajoId = 14,
                            Descripcion = "Extensiones de Cejas",
                            Precio = 700f,
                            TiempoEstimado = 30
                        },
                        new
                        {
                            TipoDeTrabajoId = 15,
                            Descripcion = "Extensiones de Uñas",
                            Precio = 700f,
                            TiempoEstimado = 30
                        },
                        new
                        {
                            TipoDeTrabajoId = 16,
                            Descripcion = "Uñas Acrilicas Para Manos",
                            Precio = 1000f,
                            TiempoEstimado = 45
                        },
                        new
                        {
                            TipoDeTrabajoId = 17,
                            Descripcion = "Uñas Gelish Para Manos",
                            Precio = 1100f,
                            TiempoEstimado = 50
                        },
                        new
                        {
                            TipoDeTrabajoId = 18,
                            Descripcion = "Uñas Esculpidas Para Manos",
                            Precio = 1200f,
                            TiempoEstimado = 50
                        },
                        new
                        {
                            TipoDeTrabajoId = 19,
                            Descripcion = "Uñas Acrigel Para Manos",
                            Precio = 1300f,
                            TiempoEstimado = 50
                        },
                        new
                        {
                            TipoDeTrabajoId = 20,
                            Descripcion = "Uñas Polygel Para Manos",
                            Precio = 1200f,
                            TiempoEstimado = 40
                        },
                        new
                        {
                            TipoDeTrabajoId = 21,
                            Descripcion = "Uñas Acrilgel Para Manos",
                            Precio = 1200f,
                            TiempoEstimado = 60
                        },
                        new
                        {
                            TipoDeTrabajoId = 22,
                            Descripcion = "Uñas Acrilicas Para Pies",
                            Precio = 1000f,
                            TiempoEstimado = 50
                        },
                        new
                        {
                            TipoDeTrabajoId = 23,
                            Descripcion = "Uñas Gelish Para Pies",
                            Precio = 1100f,
                            TiempoEstimado = 50
                        },
                        new
                        {
                            TipoDeTrabajoId = 24,
                            Descripcion = "Uñas Esculpidas Para Pies",
                            Precio = 1200f,
                            TiempoEstimado = 50
                        },
                        new
                        {
                            TipoDeTrabajoId = 25,
                            Descripcion = "Uñas Acrigel Para Pies",
                            Precio = 1300f,
                            TiempoEstimado = 40
                        },
                        new
                        {
                            TipoDeTrabajoId = 26,
                            Descripcion = "Uñas Polygel Para Pies",
                            Precio = 1200f,
                            TiempoEstimado = 60
                        },
                        new
                        {
                            TipoDeTrabajoId = 27,
                            Descripcion = "Uñas Acrilgel Para Pies",
                            Precio = 1200f,
                            TiempoEstimado = 50
                        });
                });

            modelBuilder.Entity("AguaMariaSolution.Shared.Models.Citas", b =>
                {
                    b.HasOne("AguaMariaSolution.Shared.Models.Clientes", null)
                        .WithMany("Citas")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AguaMariaSolution.Shared.Models.Colaboradores", null)
                        .WithMany("Citas")
                        .HasForeignKey("ColaboradorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AguaMariaSolution.Shared.Models.CitasDetalles", b =>
                {
                    b.HasOne("AguaMariaSolution.Shared.Models.Citas", null)
                        .WithMany("CitasDetalles")
                        .HasForeignKey("CitaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AguaMariaSolution.Shared.Models.TiposDeTrabajos", b =>
                {
                    b.HasOne("AguaMariaSolution.Shared.Models.Citas", null)
                        .WithMany("TiposDeTrabajos")
                        .HasForeignKey("CitasCitaId");

                    b.HasOne("AguaMariaSolution.Shared.Models.Colaboradores", null)
                        .WithMany("TipoDeTrabajo")
                        .HasForeignKey("ColaboradoresColaboradorId");
                });

            modelBuilder.Entity("AguaMariaSolution.Shared.Models.Citas", b =>
                {
                    b.Navigation("CitasDetalles");

                    b.Navigation("TiposDeTrabajos");
                });

            modelBuilder.Entity("AguaMariaSolution.Shared.Models.Clientes", b =>
                {
                    b.Navigation("Citas");
                });

            modelBuilder.Entity("AguaMariaSolution.Shared.Models.Colaboradores", b =>
                {
                    b.Navigation("Citas");

                    b.Navigation("TipoDeTrabajo");
                });
#pragma warning restore 612, 618
        }
    }
}
