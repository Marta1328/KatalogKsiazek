using FidoJedrzejczak.KatalogKsiazek.Core;  // Reference Core layer

namespace FidoJedrzejczak.KatalogKsiazek.DAO
{
    public class Ksiazka
    {
        public int KsiazkaID { get; set; }  // Primary key
        public string Tytul { get; set; }   // Book title
        public string Autor { get; set; }   // Author name
        public int RokWydania { get; set; } // Year of publication
        public int WydawnictwoID { get; set; } // Foreign key reference
        public decimal Cena { get; set; }   // Price
        public TypKsiazki Typ { get; set; } // Book type (now from Core)
    }
}
