using System;
using System.IO;
using SephoraClase;

namespace NivelStocareDate
{
    public class AdministrareClient_FisierText
    {
        private const int NR_MAX_CLIENTI = 50;
        private string numeFisier;

        public AdministrareClient_FisierText(string numeFisier)
        {
            this.numeFisier = numeFisier;
            // se incearca deschiderea fisierului in modul OpenOrCreate
            // astfel incat sa fie creat daca nu exista
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddClient(Client client)
        {
            // instructiunea 'using' va apela la final streamWriterFisierText.Close();
            // al doilea parametru setat la 'true' al constructorului StreamWriter indica
            // modul 'append' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(client.ConversieLaSir_PentruFisier());
            }
        }

        public Client[] GetClienti(out int nrClienti)
        {
            Client[] clienti = new Client[NR_MAX_CLIENTI];

            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrClienti = 0;

                // citeste cate o linie si creaza un obiect de tip Client
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    clienti[nrClienti++] = new Client(linieFisier);
                }
            }

            return clienti;
        }
    }
}
