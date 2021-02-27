﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectSchool_API.Data;

namespace ProjectSchool_API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201120202037_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10");

            modelBuilder.Entity("ProjectSchool_API.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DataNasc")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Alunos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataNasc = "01/01/2000",
                            Nome = "Maria",
                            ProfessorId = 1,
                            Sobrenome = "José"
                        },
                        new
                        {
                            Id = 2,
                            DataNasc = "20/01/1990",
                            Nome = "Joao",
                            ProfessorId = 2,
                            Sobrenome = "Paulo"
                        },
                        new
                        {
                            Id = 3,
                            DataNasc = "25/06/1981",
                            Nome = "Alex",
                            ProfessorId = 3,
                            Sobrenome = "Ferraz"
                        });
                });

            modelBuilder.Entity("ProjectSchool_API.Models.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Professores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Vinícius"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Paula"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Luna"
                        });
                });

            modelBuilder.Entity("ProjectSchool_API.Models.Aluno", b =>
                {
                    b.HasOne("ProjectSchool_API.Models.Professor", "Professor")
                        .WithMany("Alunos")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
