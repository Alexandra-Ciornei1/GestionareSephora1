﻿using System.Linq;
using System;
using SephoraClase;

namespace NivelStocareDate
{
    public class AdministrareClient
    {
        private const int NR_MAX_CLIENTI = 50;
        private Client[] clienti;
        private int nrClienti;

        public AdministrareClient()
        {
            clienti = new Client[NR_MAX_CLIENTI];
            nrClienti = 0;
        }

        public void AddClient(Client client)
        {
            if (nrClienti < clienti.Length)
            {
                clienti[nrClienti] = client;
                nrClienti++;
            }
            
        }

        public Client[] GetClient(out int nrClienti)
        {
            nrClienti = this.nrClienti;
            return clienti.Take(nrClienti).ToArray(); 
        }
    }
}
