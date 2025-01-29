using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace FidoJedrzejczak.KatalogKsiazek.DAO
{
    public class BookDbContextFactory : IDesignTimeDbContextFactory<BookDbContext>
    {
        public BookDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BookDbContext>();
            optionsBuilder.UseSqlite("Data Source=books.db");


            return new BookDbContext(optionsBuilder.Options);
        }
    }
}
