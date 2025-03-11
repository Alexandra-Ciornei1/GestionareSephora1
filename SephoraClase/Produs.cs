using System;

namespace SephoraClase
{
    public class Produs
    {
        // Proprietăți auto-implemented
        public string Nume { get; set; }
        public double Pret { get; set; }
        public string Categorie { get; set; }

        // Constructor
        public Produs(string nume, double pret, string categorie)
        {
            Nume = nume;
            Pret = pret;
            Categorie = categorie;
        }

        public override string ToString()
        {
            return $"Nume: {Nume}, Pret: {Pret} RON, Categorie: {Categorie}";
        }
    }
}
