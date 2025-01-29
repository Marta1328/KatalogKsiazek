using FidoJedrzejczak.KatalogKsiazek.Core;  // Reference Core layer here
using FidoJedrzejczak.KatalogKsiazek.Interfaces;  // This should reference Interfaces if needed

namespace FidoJedrzejczak.KatalogKsiazek.DAO
{
    public class Ksiazka
{
    public int KsiazkaID { get; set; }  // This is the primary key
    public string Tytul { get; set; }   // Book title
    public string Autor { get; set; }   // Author name
    public int RokWydania { get; set; } // Year of publication
    public Wydawnictwo Wydawnictwo { get; set; } // Publishing house enum
    public decimal Cena { get; set; }   // Price
    public TypKsiazki Typ { get; set; } // Book type (local enum)
}


    // Enum specific to DAO layer, stays here
    public enum TypKsiazki
    {
        Powiesc,
        Podrecznik,
        Biografia
    }
}
