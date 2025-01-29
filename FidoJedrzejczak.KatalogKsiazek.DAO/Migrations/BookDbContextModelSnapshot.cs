﻿// <auto-generated />
using FidoJedrzejczak.KatalogKsiazek.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FidoJedrzejczak.KatalogKsiazek.DAO.Migrations
{
    [DbContext(typeof(BookDbContext))]
    partial class BookDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.1");

            modelBuilder.Entity("FidoJedrzejczak.KatalogKsiazek.DAO.Ksiazka", b =>
                {
                    b.Property<int>("KsiazkaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Cena")
                        .HasColumnType("TEXT");

                    b.Property<int>("RokWydania")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Typ")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tytul")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("WydawnictwoID")
                        .HasColumnType("INTEGER");

                    b.HasKey("KsiazkaID");

                    b.ToTable("Ksiazki");

                    b.HasData(
                        new
                        {
                            KsiazkaID = 1,
                            Autor = "Jan Kowalski",
                            Cena = 29.99m,
                            RokWydania = 2000,
                            Typ = 0,
                            Tytul = "Pierwsza Książka",
                            WydawnictwoID = 1
                        },
                        new
                        {
                            KsiazkaID = 2,
                            Autor = "Anna Nowak",
                            Cena = 39.99m,
                            RokWydania = 2015,
                            Typ = 1,
                            Tytul = "Druga Książka",
                            WydawnictwoID = 2
                        });
                });

            modelBuilder.Entity("FidoJedrzejczak.KatalogKsiazek.DAO.Wydawnictwo", b =>
                {
                    b.Property<int>("WydawnictwoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("WydawnictwoID");

                    b.ToTable("Wydawnictwa");

                    b.HasData(
                        new
                        {
                            WydawnictwoID = 1,
                            Adres = "Kraków, ul. Wydawnicza 1",
                            Nazwa = "Znak"
                        },
                        new
                        {
                            WydawnictwoID = 2,
                            Adres = "Warszawa, ul. Nauki 3",
                            Nazwa = "PWN"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
