using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SephoraClase
{
    public class Client
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        private const int ID = 0;
        private const int NUME = 1;
        private const int EMAIL = 2;

        // Proprietăți auto-implemented
        public string Nume { get; set; }
        public string Email { get; set; }
        public int IDClient { get; set; }

        // Constructor
        public Client(int idClient, string nume, string email)
        {
            IDClient = idClient;
            Nume = nume;
            Email = email;
        }
        public Client(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            this.IDClient = Convert.ToInt32(dateFisier[ID]);
            this.Nume = dateFisier[NUME];
            this.Email = dateFisier[EMAIL];


        }
        

        public string ConversieLaSir_PentruFisier()
        {
            return string.Format("{1}{0}{2}{0}{3}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                IDClient.ToString(),
                (Nume ?? " NECUNOSCUT "),
                (Email ?? " NECUNOSCUT "));
                

        }
        public override string ToString()
        {
            return $"ID Client: {IDClient}, Nume: {Nume}, Email: {Email}";
        }
    }
}

