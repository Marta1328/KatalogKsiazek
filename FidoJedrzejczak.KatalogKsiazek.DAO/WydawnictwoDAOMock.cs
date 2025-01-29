using System.Collections.Generic;
using System.Linq;

namespace FidoJedrzejczak.KatalogKsiazek.DAO.Mock
{
    public class WydawnictwoRepositoryMock
    {
        private static List<Wydawnictwo> _wydawnictwa = new List<Wydawnictwo>
        {
            new Wydawnictwo { WydawnictwoID = 1, Nazwa = "Wydawnictwo A", Adres = "ul. Książkowa 10, Warszawa" },
            new Wydawnictwo { WydawnictwoID = 2, Nazwa = "Wydawnictwo B", Adres = "ul. Literacka 5, Kraków" }
        };

        public IEnumerable<Wydawnictwo> GetAll() => _wydawnictwa;

        public Wydawnictwo GetById(int id) => _wydawnictwa.FirstOrDefault(w => w.WydawnictwoID == id);

        public void Add(Wydawnictwo wydawnictwo)
        {
            wydawnictwo.WydawnictwoID = _wydawnictwa.Any() ? _wydawnictwa.Max(w => w.WydawnictwoID) + 1 : 1;
            _wydawnictwa.Add(wydawnictwo);
        }

        public void Update(Wydawnictwo wydawnictwo)
        {
            var existing = GetById(wydawnictwo.WydawnictwoID);
            if (existing != null)
            {
                existing.Nazwa = wydawnictwo.Nazwa;
                existing.Adres = wydawnictwo.Adres;
            }
        }

        public void Delete(int id) => _wydawnictwa.RemoveAll(w => w.WydawnictwoID == id);
    }
}
