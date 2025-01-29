using Microsoft.EntityFrameworkCore;
using FidoJedrzejczak.KatalogKsiazek.Core;

namespace FidoJedrzejczak.KatalogKsiazek.DAO
{
    public class BookDbContext : DbContext
    {
        public DbSet<Ksiazka> Ksiazki { get; set; }
        public DbSet<Wydawnictwo> Wydawnictwa { get; set; } // Add DbSet for Wydawnictwo

        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Wydawnictwo>().HasData(
                new Wydawnictwo { WydawnictwoID = 1, Nazwa = "Znak", Adres = "Kraków, ul. Wydawnicza 1" },
                new Wydawnictwo { WydawnictwoID = 2, Nazwa = "PWN", Adres = "Warszawa, ul. Nauki 3" }
            );


            modelBuilder.Entity<Ksiazka>().HasData(
                new Ksiazka
                {
                    KsiazkaID = 1,
                    Tytul = "Pierwsza Książka",
                    Autor = "Jan Kowalski",
                    RokWydania = 2000,
                    Cena = 29.99M,
                    WydawnictwoID = 1, // Reference WydawnictwoID (Znak)
                    Typ = TypKsiazki.Powiesc
                },
                new Ksiazka
                {
                    KsiazkaID = 2,
                    Tytul = "Druga Książka",
                    Autor = "Anna Nowak",
                    RokWydania = 2015,
                    Cena = 39.99M,
                    WydawnictwoID = 2, // Reference WydawnictwoID (PWN)
                    Typ = TypKsiazki.Podrecznik
                }
            );
        }
    }
}
