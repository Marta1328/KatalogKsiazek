using FidoJedrzejczak.KatalogKsiazek.DAO;
using System.Collections.Generic;

namespace FidoJedrzejczak.KatalogKsiazek.Interfaces
{

    public interface IWydawnictwoRepository
    {
        IEnumerable<Wydawnictwo> GetAll();
        Wydawnictwo GetById(int id);
        void Add(Wydawnictwo wydawnictwo);
        void Update(Wydawnictwo wydawnictwo);
        void Delete(int id);
    }
}
