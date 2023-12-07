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
    [Migration("20231206032320_Creando_Clase_TiposDeTrabajo")]
    partial class Creando_Clase_TiposDeTrabajo
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
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("TiempoEstimado")
                        .HasColumnType("INTEGER");

                    b.HasKey("TipoDeTrabajoId");

                    b.ToTable("TiposDeTrabajos");
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
                        .WithMany("TipoDeTrabajo")
                        .HasForeignKey("TipoDeTrabajoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AguaMariaSolution.Shared.Models.Colaboradores", null)
                        .WithMany("TipoDeTrabajo")
                        .HasForeignKey("TipoDeTrabajoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AguaMariaSolution.Shared.Models.Citas", b =>
                {
                    b.Navigation("CitasDetalles");

                    b.Navigation("TipoDeTrabajo");
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
