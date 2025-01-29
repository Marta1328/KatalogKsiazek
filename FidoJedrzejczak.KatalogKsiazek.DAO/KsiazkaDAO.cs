using System.Linq;
using FidoJedrzejczak.KatalogKsiazek.Core;
using Microsoft.EntityFrameworkCore;

namespace FidoJedrzejczak.KatalogKsiazek.DAO
{
    public class KsiazkaRepository
    {
        private readonly BookDbContext _context;

        public KsiazkaRepository(BookDbContext context)
        {
            _context = context;
        }

        public void Add(Ksiazka ksiazka)
        {
            _context.Ksiazki.Add(ksiazka);
            _context.SaveChanges();
        }

        public IQueryable<Ksiazka> GetAll()
        {
            return _context.Ksiazki.AsQueryable();
        }

        public Ksiazka GetById(int id)
        {
            return _context.Ksiazki.FirstOrDefault(k => k.KsiazkaID == id);
        }
    }
}
