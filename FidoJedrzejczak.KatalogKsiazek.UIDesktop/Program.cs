using Microsoft.EntityFrameworkCore;
using FidoJedrzejczak.KatalogKsiazek.DAO;
using System;
using FidoJedrzejczak.KatalogKsiazek.Core;


namespace FidoJedrzejczak.KatalogKsiazek.UIDesktop
{
    class Program
    {
        static void Main(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BookDbContext>();
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\marta\\Documents\\wis\\FidoJedrzejczak.KatalogKsiazek\\FidoJedrzejczak.KatalogKsiazek.DAO\\books.db");

            using (var context = new BookDbContext(optionsBuilder.Options))
            {
                // Make sure to create the database if it doesn't exist
                context.Database.Migrate();

            

                context.SaveChanges();
            }

            Console.WriteLine("Book added to the database!");
        }
    }
}
