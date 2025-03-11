using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SephoraClase
{
    public class Client
    {
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

       
        public override string ToString()
        {
            return $"ID Client: {IDClient}, Nume: {Nume}, Email: {Email}";
        }
    }
}

