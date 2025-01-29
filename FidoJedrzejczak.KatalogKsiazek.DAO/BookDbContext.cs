using Microsoft.EntityFrameworkCore;
using FidoJedrzejczak.KatalogKsiazek.Core;

namespace FidoJedrzejczak.KatalogKsiazek.DAO
{
    public class BookDbContext : DbContext
    {
        // Define your DbSet for each entity (table)
        public DbSet<Ksiazka> Ksiazki { get; set; }

        // Constructor that receives DbContextOptions and passes it to the base class
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
        {
        }

        // Customize model creation (optional)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Example of seeding some initial data
            modelBuilder.Entity<Ksiazka>().HasData(
                new Ksiazka
                {
                    KsiazkaID = 1,
                    Tytul = "Pierwsza Książka",
                    Autor = "Jan Kowalski",
                    RokWydania = 2000,
                    Cena = 29.99M,
                    Wydawnictwo = Wydawnictwo.Znak,
                    Typ = TypKsiazki.Powiesc
                },
                new Ksiazka
                {
                    KsiazkaID = 2,
                    Tytul = "Druga Książka",
                    Autor = "Anna Nowak",
                    RokWydania = 2015,
                    Cena = 39.99M,
                    Wydawnictwo = Wydawnictwo.Znak,
                    Typ = TypKsiazki.Podrecznik
                }
            );
        }
    }
}
