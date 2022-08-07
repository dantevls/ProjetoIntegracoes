﻿// <auto-generated />
using System;
using Infra.Data.MercadoLivre.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infra.Data.MercadoLivre.Migrations
{
    [DbContext(typeof(MercadoLivreContext))]
    partial class MercadoLivreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-preview.5.22302.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.MercadoLivre.Anuncio", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Control_DataAlter")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Control_DataInc")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Descricao");

                    b.Property<Guid>("PlanoId")
                        .HasColumnType("uuid")
                        .HasColumnName("PlanoId");

                    b.Property<Guid>("SistemaExternoId")
                        .HasColumnType("uuid")
                        .HasColumnName("SistemaExternoId");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Titulo");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uuid")
                        .HasColumnName("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("PlanoId");

                    b.HasIndex("SistemaExternoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Anuncio", "MercadoLivre");
                });

            modelBuilder.Entity("Domain.MercadoLivre.Plano", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Control_DataAlter")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Control_DataInc")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Destaque")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("QtdAnuncios")
                        .HasColumnType("numeric");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Plano", "MercadoLivre");
                });

            modelBuilder.Entity("Domain.MercadoLivre.SistemaExterno", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("SistemaExterno");
                });

            modelBuilder.Entity("Domain.MercadoLivre.UsuarioMercadoLivre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("UsuarioId");

                    b.Property<string>("Client_Id")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Client_Id");

                    b.Property<string>("Client_Secret")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Client_Secret");

                    b.Property<string>("RefreshToken")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Token");

                    b.HasKey("Id");

                    b.ToTable("UsuarioMercadoLivre", "MercadoLivre");
                });

            modelBuilder.Entity("Domain.MercadoLivre.Anuncio", b =>
                {
                    b.HasOne("Domain.MercadoLivre.Plano", "Plano")
                        .WithMany("Anuncio")
                        .HasForeignKey("PlanoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.MercadoLivre.SistemaExterno", "SistemaExterno")
                        .WithMany()
                        .HasForeignKey("SistemaExternoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.MercadoLivre.UsuarioMercadoLivre", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Plano");

                    b.Navigation("SistemaExterno");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Domain.MercadoLivre.Plano", b =>
                {
                    b.Navigation("Anuncio");
                });
#pragma warning restore 612, 618
        }
    }
}
