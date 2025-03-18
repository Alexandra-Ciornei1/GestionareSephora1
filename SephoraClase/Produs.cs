using System;

namespace SephoraClase
{
    public class Produs
    {
        // Proprietăți auto-implemented
        public string Nume { get; set; }
        public double Pret { get; set; }
        public string Categorie { get; set; }

        private const char SEPARATOR_PRINCIPAL_FISIER = ',';
        private const int NUME = 0;
        private const int PRET = 1;
        private const int CATEGORIE = 2;

        // Constructor
        public Produs(string nume, double pret, string categorie)
        {
            Nume = nume;
            Pret = pret;
            Categorie = categorie;
        }

        public Produs(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            // ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier
            this.Nume = dateFisier[NUME].Split(':')[1].Trim();
            this.Pret = double.Parse(dateFisier[PRET].Split(':')[1].Trim().Split(' ')[0]);
            this.Categorie = dateFisier[CATEGORIE].Split(':')[1].Trim();
        }

        public override string ToString()
        {
            return $"Nume: {Nume}, Pret: {Pret} RON, Categorie: {Categorie}";
        }
    }
}

