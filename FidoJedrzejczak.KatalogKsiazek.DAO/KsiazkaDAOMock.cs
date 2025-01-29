using FidoJedrzejczak.KatalogKsiazek.Core;
using System.Collections.Generic;

namespace FidoJedrzejczak.KatalogKsiazek.DAO
{
    public class BookRepositoryMock
    {
        private List<Ksiazka> _books;

        public BookRepositoryMock()
        {
            _books = new List<Ksiazka>
            {
                new Ksiazka { KsiazkaID = 1, Tytul = "Mock Book 1", Autor = "Author 1", RokWydania = 2000, Cena = 20.99M, WydawnictwoID = 1, Typ = TypKsiazki.Powiesc },
                new Ksiazka { KsiazkaID = 2, Tytul = "Mock Book 2", Autor = "Author 2", RokWydania = 2010, Cena = 35.50M, WydawnictwoID = 2, Typ = TypKsiazki.Podrecznik }
        
            };
            
        }

        public IEnumerable<Ksiazka> GetAllBooks()
        {
            return _books;
        }

        public void AddBook(Ksiazka ksiazka)
        {
            _books.Add(ksiazka);
        }

        public void DeleteBook(int id)
        {
            var book = _books.Find(b => b.KsiazkaID == id);
            if (book != null)
            {
                _books.Remove(book);
            }
        }

        public Ksiazka GetBookById(int id)
        {
            return _books.Find(b => b.KsiazkaID == id);
        }
    }
}
