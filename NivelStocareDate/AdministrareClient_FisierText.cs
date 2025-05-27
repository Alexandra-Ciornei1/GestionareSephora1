using System;
using System.IO;
using SephoraClase;

namespace NivelStocareDate
{
    public class AdministrareClient_FisierText
    {
        private const int NR_MAX_CLIENTI = 50;
        private string numeFisier;

        // Inițializează clasa și creează sau deschide fișierul pentru clienți
        public AdministrareClient_FisierText(string numeFisier)
        {
            this.numeFisier = numeFisier;
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        // Adaugă un client nou în fișierul text
        public void AddClient(Client client)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(client.ConversieLaSir_PentruFisier());
            }
        }

        // Citește toți clienții din fișier și îi returnează ca un array
        public Client[] GetClienti(out int nrClienti)
        {
            Client[] clienti = new Client[NR_MAX_CLIENTI];
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrClienti = 0;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    clienti[nrClienti++] = new Client(linieFisier);
                }
            }
            return clienti;
        }

        // Returnează un client specific din fișier pe baza indexului
        public Client GetClient(int index)
        {
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                int currentIndex = 0;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    if (currentIndex == index)
                    {
                        return new Client(linieFisier);
                    }
                    currentIndex++;
                }
            }
            throw new Exception("Clientul cu indexul specificat nu există.");
        }

        // Actualizează informațiile unui client existent în fișier
        public bool UpdateClient(Client clientActualizat)
        {
            try
            {
                Client[] clienti;
                int nrClienti;
                clienti = GetClienti(out nrClienti);
                bool clientGasit = false;

                for (int i = 0; i < nrClienti; i++)
                {
                    if (clienti[i].IDClient == clientActualizat.IDClient)
                    {
                        clienti[i] = clientActualizat;
                        clientGasit = true;
                        break;
                    }
                }

                if (!clientGasit)
                {
                    return false;
                }

                using (StreamWriter streamWriter = new StreamWriter(numeFisier, false))
                {
                    for (int i = 0; i < nrClienti; i++)
                    {
                        streamWriter.WriteLine(clienti[i].ConversieLaSir_PentruFisier());
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Eroare la actualizarea clientului: {ex.Message}");
            }
        }
    }
}
