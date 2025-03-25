using System;
using System.Net.Sockets;

namespace SephoraClase
{
    public class Produs
    {
        // Proprietăți auto-implemented
        public string Nume { get; set; }
        public int Pret { get; set; }
        public string Cantitate { get; set; }

        public Categorii CategorieProd { get; set; }

        private const char SEPARATOR_PRINCIPAL_FISIER = ',';
        private const int NUME = 0;
        private const int PRET = 1;
        private const int CANTITATE = 2;
        private const int CAT = 3;

        // Constructor
        public Produs(string nume, int pret, string cantitate)
        {
            Nume = nume;
            Pret = pret;
            Cantitate = cantitate;
           
        }

        public Produs()
        {
            Nume = string.Empty;
            Pret = 0;
            Cantitate = string.Empty;
        }
        public Produs(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            // ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier
            this.Nume = dateFisier[NUME];


            this.Pret = Convert.ToInt32(dateFisier[PRET]);
            
            this.Cantitate = dateFisier[CANTITATE];
            //this.CategorieProd = (Categorii)Enum.Parse(typeof(Categorii), dateFisier[CAT]);
        }

        public string ConversieLaSir_PentruFisier()
        {
            return string.Format("{1}{0}{2}{0}{3}{0}{4}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                (Nume ?? " NECUNOSCUT "),
                Pret.ToString(),
                (Cantitate ?? " NECUNOSCUT "),
                CategorieProd.ToString());

          
        }
        public override string ToString()
        {
            return $"Nume: {Nume}, Pret: {Pret}, Cantitate: {Cantitate}, Categorie: {CategorieProd} \n";
        }
    }
}

