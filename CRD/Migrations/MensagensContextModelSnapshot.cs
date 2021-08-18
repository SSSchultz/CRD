﻿// <auto-generated />
using CRD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRD.Migrations
{
    [DbContext(typeof(MensagensContext))]
    partial class MensagensContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("CRD.Models.Mensagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("TextoDoComunicado")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TipoDeUsuario")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TituloDoComunicado")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Mensagens");
                });
#pragma warning restore 612, 618
        }
    }
}