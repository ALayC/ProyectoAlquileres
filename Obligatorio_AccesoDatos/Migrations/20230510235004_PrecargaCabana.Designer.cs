﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Obligatorio_AccesoDatos;

#nullable disable

namespace Obligatorio_AccesoDatos.Migrations
{
    [DbContext(typeof(ObligatorioDBContext))]
    [Migration("20230510235004_PrecargaCabana")]
    partial class PrecargaCabana
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Obligatorio_LogicaNegocio.Entidades.Cabana", b =>
                {
                    b.Property<string>("Nombre")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("CapacidadMaxima")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("HabilitadaReservas")
                        .HasColumnType("bit");

                    b.Property<string>("Imagen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("JacuzziPrivado")
                        .HasColumnType("bit");

                    b.Property<int>("NumeroHabitacion")
                        .HasColumnType("int");

                    b.Property<string>("TipoCabanaNombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Nombre");

                    b.HasIndex("TipoCabanaNombre");

                    b.ToTable("Cabanas");
                });

            modelBuilder.Entity("Obligatorio_LogicaNegocio.Entidades.Mantenimiento", b =>
                {
                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CabanaNombre")
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Costo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumeroHabitacion")
                        .HasColumnType("int");

                    b.Property<string>("Trabajador")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Descripcion");

                    b.HasIndex("CabanaNombre");

                    b.ToTable("Mantenimientos");
                });

            modelBuilder.Entity("Obligatorio_LogicaNegocio.Entidades.TipoCabana", b =>
                {
                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("CostoPorHuesped")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdTipoCabana")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTipoCabana"));

                    b.HasKey("Nombre");

                    b.ToTable("TipoCabanas");
                });

            modelBuilder.Entity("Obligatorio_LogicaNegocio.Entidades.Usuario", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.HasKey("Email");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Obligatorio_LogicaNegocio.Entidades.Cabana", b =>
                {
                    b.HasOne("Obligatorio_LogicaNegocio.Entidades.TipoCabana", "TipoCabana")
                        .WithMany()
                        .HasForeignKey("TipoCabanaNombre")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoCabana");
                });

            modelBuilder.Entity("Obligatorio_LogicaNegocio.Entidades.Mantenimiento", b =>
                {
                    b.HasOne("Obligatorio_LogicaNegocio.Entidades.Cabana", null)
                        .WithMany("Mantenimientos")
                        .HasForeignKey("CabanaNombre");
                });

            modelBuilder.Entity("Obligatorio_LogicaNegocio.Entidades.Cabana", b =>
                {
                    b.Navigation("Mantenimientos");
                });
#pragma warning restore 612, 618
        }
    }
}
