﻿// <auto-generated />
using System;
using FestivalApplication.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FestivalApplication.Migrations
{
    [DbContext(typeof(FestivalContext))]
    [Migration("20230108195006_migration1")]
    partial class migration1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FestivalApplication.Models.Artiest", b =>
                {
                    b.Property<int>("ArtiestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Afbeelding")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Beschrijving")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Facebook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instagram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Spotify")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArtiestId");

                    b.ToTable("Artiest");
                });

            modelBuilder.Entity("FestivalApplication.Models.ArtiestDatum", b =>
                {
                    b.Property<int>("ArtiestDatumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtiestId")
                        .HasColumnType("int");

                    b.Property<string>("Beginuur")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<string>("Einduur")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StageId")
                        .HasColumnType("int");

                    b.HasKey("ArtiestDatumId");

                    b.HasIndex("ArtiestId");

                    b.HasIndex("StageId");

                    b.ToTable("ArtiestDatum");
                });

            modelBuilder.Entity("FestivalApplication.Models.ArtiestGenre", b =>
                {
                    b.Property<int>("ArtiestGenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtiestId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.HasKey("ArtiestGenreId");

                    b.HasIndex("ArtiestId");

                    b.HasIndex("GenreId");

                    b.ToTable("ArtiestGenre");
                });

            modelBuilder.Entity("FestivalApplication.Models.Factuur", b =>
                {
                    b.Property<int>("FactuurId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int>("GebruikerId")
                        .HasColumnType("int");

                    b.HasKey("FactuurId");

                    b.HasIndex("GebruikerId");

                    b.ToTable("Factuur");
                });

            modelBuilder.Entity("FestivalApplication.Models.FactuurProduct", b =>
                {
                    b.Property<int>("FactuurProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Aantal")
                        .HasColumnType("int");

                    b.Property<int>("FactuurId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("FactuurProductId");

                    b.HasIndex("FactuurId");

                    b.HasIndex("ProductId");

                    b.ToTable("FactuurProduct");
                });

            modelBuilder.Entity("FestivalApplication.Models.Gebruiker", b =>
                {
                    b.Property<int>("GebruikerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Dorp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Geboortedatum")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gebruikersnaam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Huisnummer")
                        .HasColumnType("int");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Postcode")
                        .HasColumnType("int");

                    b.Property<string>("Straatnaam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefoonnummer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Voornaam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GebruikerId");

                    b.ToTable("Gebruiker");
                });

            modelBuilder.Entity("FestivalApplication.Models.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreId");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("FestivalApplication.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtiestId")
                        .HasColumnType("int");

                    b.Property<string>("Beschrijving")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Prijs")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("ArtiestId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("FestivalApplication.Models.Stage", b =>
                {
                    b.Property<int>("StageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StageId");

                    b.ToTable("Stage");
                });

            modelBuilder.Entity("FestivalApplication.Models.ArtiestDatum", b =>
                {
                    b.HasOne("FestivalApplication.Models.Artiest", "Artiest")
                        .WithMany("ArtiestDatums")
                        .HasForeignKey("ArtiestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FestivalApplication.Models.Stage", "Stage")
                        .WithMany("ArtiestDatums")
                        .HasForeignKey("StageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FestivalApplication.Models.ArtiestGenre", b =>
                {
                    b.HasOne("FestivalApplication.Models.Artiest", "Artiest")
                        .WithMany("ArtiestGenres")
                        .HasForeignKey("ArtiestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FestivalApplication.Models.Genre", "Genre")
                        .WithMany("ArtiestGenres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FestivalApplication.Models.Factuur", b =>
                {
                    b.HasOne("FestivalApplication.Models.Gebruiker", "Gebruiker")
                        .WithMany("Facturen")
                        .HasForeignKey("GebruikerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FestivalApplication.Models.FactuurProduct", b =>
                {
                    b.HasOne("FestivalApplication.Models.Factuur", "Factuur")
                        .WithMany("FactuurProducten")
                        .HasForeignKey("FactuurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FestivalApplication.Models.Product", "Product")
                        .WithMany("FactuurProducten")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FestivalApplication.Models.Product", b =>
                {
                    b.HasOne("FestivalApplication.Models.Artiest", "Artiest")
                        .WithMany("Producten")
                        .HasForeignKey("ArtiestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
