﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using livrariaApi.context;

#nullable disable

namespace livrariaApi.Migrations
{
    [DbContext(typeof(LivroDbContext))]
    partial class LivroDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("livrariaApi.models.Assunto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext")
                        .HasColumnName("DESCRICAO");

                    b.HasKey("Id");

                    b.ToTable("Assuntos");
                });

            modelBuilder.Entity("livrariaApi.models.Autor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext")
                        .HasColumnName("NOME");

                    b.HasKey("Id");

                    b.ToTable("Autores");
                });

            modelBuilder.Entity("livrariaApi.models.Livro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("AnoPublicado")
                        .HasColumnType("longtext")
                        .HasColumnName("ANO_PUBLICADO");

                    b.Property<int?>("Edicao")
                        .HasColumnType("int")
                        .HasColumnName("EDICAO");

                    b.Property<string>("Editora")
                        .HasColumnType("longtext")
                        .HasColumnName("EDITORA");

                    b.HasKey("Id");

                    b.ToTable("livros");
                });

            modelBuilder.Entity("livrariaApi.models.LivroAssunto", b =>
                {
                    b.Property<int>("LivroId")
                        .HasColumnType("int");

                    b.Property<int>("AssuntoId")
                        .HasColumnType("int");

                    b.HasKey("LivroId", "AssuntoId");

                    b.HasIndex("AssuntoId");

                    b.ToTable("LivroAssuntos");
                });

            modelBuilder.Entity("livrariaApi.models.LivroAutor", b =>
                {
                    b.Property<int>("LivroId")
                        .HasColumnType("int");

                    b.Property<int>("AutorId")
                        .HasColumnType("int");

                    b.HasKey("LivroId", "AutorId");

                    b.HasIndex("AutorId");

                    b.ToTable("LivroAutores");
                });

            modelBuilder.Entity("livrariaApi.models.LivroAssunto", b =>
                {
                    b.HasOne("livrariaApi.models.Assunto", "Assunto")
                        .WithMany("LivroAssuntos")
                        .HasForeignKey("AssuntoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("livrariaApi.models.Livro", "Livro")
                        .WithMany("LivroAssuntos")
                        .HasForeignKey("LivroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assunto");

                    b.Navigation("Livro");
                });

            modelBuilder.Entity("livrariaApi.models.LivroAutor", b =>
                {
                    b.HasOne("livrariaApi.models.Autor", "Autor")
                        .WithMany("LivroAutores")
                        .HasForeignKey("AutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("livrariaApi.models.Livro", "Livro")
                        .WithMany("LivroAutores")
                        .HasForeignKey("LivroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Autor");

                    b.Navigation("Livro");
                });

            modelBuilder.Entity("livrariaApi.models.Assunto", b =>
                {
                    b.Navigation("LivroAssuntos");
                });

            modelBuilder.Entity("livrariaApi.models.Autor", b =>
                {
                    b.Navigation("LivroAutores");
                });

            modelBuilder.Entity("livrariaApi.models.Livro", b =>
                {
                    b.Navigation("LivroAssuntos");

                    b.Navigation("LivroAutores");
                });
#pragma warning restore 612, 618
        }
    }
}
