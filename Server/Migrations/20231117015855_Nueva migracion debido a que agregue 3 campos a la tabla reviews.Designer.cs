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
    [Migration("20231117015855_Nueva migracion debido a que agregue 3 campos a la tabla reviews")]
    partial class Nuevamigraciondebidoaqueagregue3camposalatablareviews
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("AguaMariaSolution.Shared.Models.Clientes", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ClienteId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("AguaMariaSolution.Shared.Models.ControlCalidadAgua", b =>
                {
                    b.Property<int>("ControlCalidadAguaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AcciónTomada")
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<int>("EmpleadoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EntidadMuestreoAguaId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("TandaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ControlCalidadAguaId");

                    b.ToTable("ControlCalidadAgua");
                });

            modelBuilder.Entity("AguaMariaSolution.Shared.Models.ControlCalidadAguaDetalle", b =>
                {
                    b.Property<int>("ControlCalidadAguaDetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ControlCalidadAguaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ParametroId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Pasó")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Valor")
                        .HasColumnType("REAL");

                    b.HasKey("ControlCalidadAguaDetalleId");

                    b.HasIndex("ControlCalidadAguaId");

                    b.ToTable("ControlCalidadAguaDetalle");
                });

            modelBuilder.Entity("AguaMariaSolution.Shared.Models.ControlCalidadProductoTerminado", b =>
                {
                    b.Property<int>("ProductoTerminadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AcciónTomada")
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<int>("EmpleadoId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.HasKey("ProductoTerminadoId");

                    b.HasIndex("EmpleadoId");

                    b.ToTable("ControlCalidadProductoTerminado");
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
                });

            modelBuilder.Entity("AguaMariaSolution.Shared.Models.EntidadesMuestreoAgua", b =>
                {
                    b.Property<int>("EntidadesMuestreoAguaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripción")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("EntidadesMuestreoAguaId");

                    b.ToTable("EntidadesMuestreoAgua");

                    b.HasData(
                        new
                        {
                            EntidadesMuestreoAguaId = 1,
                            Descripción = "Cisterna 1"
                        },
                        new
                        {
                            EntidadesMuestreoAguaId = 2,
                            Descripción = "Cisterna 2"
                        },
                        new
                        {
                            EntidadesMuestreoAguaId = 3,
                            Descripción = "Cisterna 3"
                        },
                        new
                        {
                            EntidadesMuestreoAguaId = 4,
                            Descripción = "INAPA"
                        },
                        new
                        {
                            EntidadesMuestreoAguaId = 5,
                            Descripción = "Filtro Carbón Activado"
                        },
                        new
                        {
                            EntidadesMuestreoAguaId = 6,
                            Descripción = "Ablandadores"
                        },
                        new
                        {
                            EntidadesMuestreoAguaId = 7,
                            Descripción = "Ósmosis"
                        });
                });

            modelBuilder.Entity("AguaMariaSolution.Shared.Models.Parametros", b =>
                {
                    b.Property<int>("ParametroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripción")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Máximo")
                        .HasColumnType("REAL");

                    b.Property<float>("Mínimo")
                        .HasColumnType("REAL");

                    b.HasKey("ParametroId");

                    b.ToTable("Parametros");

                    b.HasData(
                        new
                        {
                            ParametroId = 1,
                            Descripción = "Cloruro",
                            Máximo = 250f,
                            Mínimo = 0f
                        },
                        new
                        {
                            ParametroId = 2,
                            Descripción = "Cloro Residual",
                            Máximo = 0f,
                            Mínimo = 0f
                        },
                        new
                        {
                            ParametroId = 3,
                            Descripción = "STD",
                            Máximo = 500f,
                            Mínimo = 0f
                        },
                        new
                        {
                            ParametroId = 4,
                            Descripción = "Conductancia",
                            Máximo = 700f,
                            Mínimo = 0f
                        },
                        new
                        {
                            ParametroId = 5,
                            Descripción = "Dureza",
                            Máximo = 500f,
                            Mínimo = 0f
                        },
                        new
                        {
                            ParametroId = 6,
                            Descripción = "PH",
                            Máximo = 8.5f,
                            Mínimo = 6.5f
                        },
                        new
                        {
                            ParametroId = 7,
                            Descripción = "Sulfato",
                            Máximo = 250f,
                            Mínimo = 0f
                        },
                        new
                        {
                            ParametroId = 8,
                            Descripción = "Nitrato",
                            Máximo = 10f,
                            Mínimo = 0f
                        },
                        new
                        {
                            ParametroId = 9,
                            Descripción = "Hierro",
                            Máximo = 0.3f,
                            Mínimo = 0f
                        },
                        new
                        {
                            ParametroId = 10,
                            Descripción = "Color",
                            Máximo = 5f,
                            Mínimo = 0f
                        },
                        new
                        {
                            ParametroId = 11,
                            Descripción = "Turbidez",
                            Máximo = 0.5f,
                            Mínimo = 0f
                        },
                        new
                        {
                            ParametroId = 12,
                            Descripción = "Sabor",
                            Máximo = 1f,
                            Mínimo = 1f
                        },
                        new
                        {
                            ParametroId = 13,
                            Descripción = "Ozono",
                            Máximo = 0.1f,
                            Mínimo = 0.05f
                        },
                        new
                        {
                            ParametroId = 14,
                            Descripción = "Lamp UV",
                            Máximo = 1f,
                            Mínimo = 1f
                        },
                        new
                        {
                            ParametroId = 20,
                            Descripción = "Cloro Residual",
                            Máximo = 1.5f,
                            Mínimo = 1f
                        },
                        new
                        {
                            ParametroId = 21,
                            Descripción = "Dureza",
                            Máximo = 500f,
                            Mínimo = 68.4f
                        },
                        new
                        {
                            ParametroId = 22,
                            Descripción = "STD",
                            Máximo = 1000f,
                            Mínimo = 70f
                        },
                        new
                        {
                            ParametroId = 23,
                            Descripción = "Color",
                            Máximo = 15f,
                            Mínimo = 5f
                        },
                        new
                        {
                            ParametroId = 24,
                            Descripción = "Turbidez",
                            Máximo = 25f,
                            Mínimo = 10f
                        },
                        new
                        {
                            ParametroId = 25,
                            Descripción = "Sulfato",
                            Máximo = 400f,
                            Mínimo = 250f
                        },
                        new
                        {
                            ParametroId = 26,
                            Descripción = "Nitrato",
                            Máximo = 50f,
                            Mínimo = 10f
                        },
                        new
                        {
                            ParametroId = 27,
                            Descripción = "PH",
                            Máximo = 8.5f,
                            Mínimo = 6.5f
                        },
                        new
                        {
                            ParametroId = 30,
                            Descripción = "Cloro Residual",
                            Máximo = 0.05f,
                            Mínimo = 0f
                        },
                        new
                        {
                            ParametroId = 31,
                            Descripción = "Color",
                            Máximo = 15f,
                            Mínimo = 5f
                        },
                        new
                        {
                            ParametroId = 32,
                            Descripción = "Turbidez",
                            Máximo = 25f,
                            Mínimo = 10f
                        },
                        new
                        {
                            ParametroId = 33,
                            Descripción = "Olor",
                            Máximo = 1f,
                            Mínimo = 0f
                        },
                        new
                        {
                            ParametroId = 40,
                            Descripción = "Dureza",
                            Máximo = 500f,
                            Mínimo = 0f
                        },
                        new
                        {
                            ParametroId = 41,
                            Descripción = "STD",
                            Máximo = 1000f,
                            Mínimo = 70f
                        },
                        new
                        {
                            ParametroId = 42,
                            Descripción = "PH",
                            Máximo = 8.5f,
                            Mínimo = 6.5f
                        },
                        new
                        {
                            ParametroId = 50,
                            Descripción = "PH",
                            Máximo = 8.5f,
                            Mínimo = 6.5f
                        },
                        new
                        {
                            ParametroId = 51,
                            Descripción = "STD",
                            Máximo = 500f,
                            Mínimo = 2f
                        });
                });

            modelBuilder.Entity("AguaMariaSolution.Shared.Models.ProductoTerminadosDetalle", b =>
                {
                    b.Property<int>("DetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ParametroId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Pasó")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductoTerminadoId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Valor")
                        .HasColumnType("REAL");

                    b.HasKey("DetalleId");

                    b.HasIndex("ProductoTerminadoId");

                    b.ToTable("ProductoTerminadosDetalle");
                });

            modelBuilder.Entity("AguaMariaSolution.Shared.Models.Reviews", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Comentario")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Valoración")
                        .HasColumnType("INTEGER");

                    b.HasKey("ReviewId");

                    b.HasIndex("ClienteId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("AguaMariaSolution.Shared.Models.ControlCalidadAguaDetalle", b =>
                {
                    b.HasOne("AguaMariaSolution.Shared.Models.ControlCalidadAgua", null)
                        .WithMany("ControlCalidadAguaDetalle")
                        .HasForeignKey("ControlCalidadAguaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AguaMariaSolution.Shared.Models.ControlCalidadProductoTerminado", b =>
                {
                    b.HasOne("AguaMariaSolution.Shared.Models.Empleados", null)
                        .WithMany("ControlCalidadProductoTerminado")
                        .HasForeignKey("EmpleadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AguaMariaSolution.Shared.Models.ProductoTerminadosDetalle", b =>
                {
                    b.HasOne("AguaMariaSolution.Shared.Models.ControlCalidadProductoTerminado", null)
                        .WithMany("ProductoTerminadosDetalle")
                        .HasForeignKey("ProductoTerminadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AguaMariaSolution.Shared.Models.Reviews", b =>
                {
                    b.HasOne("AguaMariaSolution.Shared.Models.Clientes", null)
                        .WithMany("Reviews")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AguaMariaSolution.Shared.Models.Clientes", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("AguaMariaSolution.Shared.Models.ControlCalidadAgua", b =>
                {
                    b.Navigation("ControlCalidadAguaDetalle");
                });

            modelBuilder.Entity("AguaMariaSolution.Shared.Models.ControlCalidadProductoTerminado", b =>
                {
                    b.Navigation("ProductoTerminadosDetalle");
                });

            modelBuilder.Entity("AguaMariaSolution.Shared.Models.Empleados", b =>
                {
                    b.Navigation("ControlCalidadProductoTerminado");
                });
#pragma warning restore 612, 618
        }
    }
}
