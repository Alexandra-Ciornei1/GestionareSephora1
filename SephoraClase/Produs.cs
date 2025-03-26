using System;

namespace SephoraClase
{
    public class Produs
    {
        // Constante
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        private const int NUME = 0;
        private const int PRET = 1;
        private const int CANTITATE = 2;
        private const int CAT = 3;

        // Proprietăți auto-implemented
        public string Nume { get; set; }
        public int Pret { get; set; }
        public string Cantitate { get; set; }
        public Categorii CategorieProd { get; set; }

        // Constructor implicit
        public Produs()
        {
            Nume = string.Empty;
            Pret = 0;
            Cantitate = string.Empty;
        }

        // Constructor cu parametri
        public Produs(string nume, int pret, string cantitate)
        {
            Nume = nume;
            Pret = pret;
            Cantitate = cantitate;
        }

        // Constructor cu un singur parametru de tip string care reprezintă o linie dintr-un fișier text
        public Produs(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            this.Nume = dateFisier[NUME];
            this.Pret = Convert.ToInt32(dateFisier[PRET]);
            this.Cantitate = dateFisier[CANTITATE];
            this.CategorieProd = (Categorii)Enum.Parse(typeof(Categorii), dateFisier[CAT]);
        }

        // Metodă pentru conversia la șir pentru fișier
        public string ConversieLaSir_PentruFisier()
        {
            return string.Format("{1}{0}{2}{0}{3}{0}{4}",
                SEPARATOR_PRINCIPAL_FISIER,
                (Nume ?? " NECUNOSCUT "),
                Pret.ToString(),
                (Cantitate ?? " NECUNOSCUT "),
                CategorieProd.ToString());
        }

        // Metodă pentru afișarea informațiilor despre produs
        public string Info()
        {
            return $"Nume: {Nume}, Pret: {Pret}, Cantitate: {Cantitate}, Categorie: {CategorieProd}";
        }

        public override string ToString()
        {
            return Info();
        }

        public bool ValidarePret(int pret)
        {
            if (pret > 0)
                return true;
            else 
                return false;
        }

    }
}
