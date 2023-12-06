﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegistroCarrosdosAlunosIF.Dados;

#nullable disable

namespace RegistroCarrosdosAlunosIF.Migrations
{
    [DbContext(typeof(CadastroDbContext))]
    partial class CadastroDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RegistroCarrosdosAlunosIF.Models.Cadastros", b =>
                {
                    b.Property<string>("Prontuário")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Ano")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CNH")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Curso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Período")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Prontuário");

                    b.HasIndex("CNH")
                        .IsUnique();

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Placa")
                        .IsUnique();

                    b.HasIndex("Telefone")
                        .IsUnique();

                    b.ToTable("Cadastros");
                });
#pragma warning restore 612, 618
        }
    }
}
