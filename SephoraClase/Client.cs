using System;

namespace SephoraClase
{
    public class Client
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ','; 

        private const int ID = 0;
        private const int NUME = 1;
        private const int EMAIL = 2;
        private const int PREFERINTE = 3;

        // Proprietăți auto-implemented
        public int IDClient { get; set; }
        public string Nume { get; set; }
        public string Email { get; set; }
        public string Preferinte { get; set; } 

        // Constructor implicit
        public Client()
        {
            IDClient = 0;
            Nume = string.Empty;
            Email = string.Empty;
            Preferinte = string.Empty;
        }

        // Constructor cu parametri
        public Client(int idClient, string nume, string email, string preferinte = "")
        {
            IDClient = idClient;
            Nume = nume;
            Email = email;
            Preferinte = preferinte;
        }

        // Constructor pentru citire din fișier
        public Client(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            if (dateFisier.Length > ID)
                this.IDClient = Convert.ToInt32(dateFisier[ID]);
            if (dateFisier.Length > NUME)
                this.Nume = dateFisier[NUME];
            if (dateFisier.Length > EMAIL)
                this.Email = dateFisier[EMAIL];
            if (dateFisier.Length > PREFERINTE)
                this.Preferinte = dateFisier[PREFERINTE] ?? string.Empty;
            else
                this.Preferinte = string.Empty;
        }

        public string ConversieLaSir_PentruFisier()
        {
            return $"{IDClient}{SEPARATOR_PRINCIPAL_FISIER}" +
                   $"{(Nume ?? "NECUNOSCUT")}{SEPARATOR_PRINCIPAL_FISIER}" +
                   $"{(Email ?? "NECUNOSCUT")}{SEPARATOR_PRINCIPAL_FISIER}" +
                   $"{(Preferinte ?? "")}";
        }

        public override string ToString()
        {
            return $"ID Client: {IDClient}, Nume: {Nume}, Email: {Email}, Preferințe: {Preferinte}";
        }
    }
}