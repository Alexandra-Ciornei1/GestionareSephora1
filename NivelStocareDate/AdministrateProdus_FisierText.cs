using System;
using System.IO;
using SephoraClase;

namespace NivelStocareDate
{
    public class AdministrareProdus_FisierText
    {
        private const int NR_MAX_PRODUSE = 50;
        private string filePath;

        public AdministrareProdus_FisierText(string filePath)
        {
            this.filePath = filePath;
            Stream streamFisierText = File.Open(filePath, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddProdus(Produs produs)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(filePath, true))
            {
                streamWriterFisierText.WriteLine(produs.ConversieLaSir_PentruFisier());
            }
        }

        public Produs[] GetProduse(out int nrProduse)
        {
            Produs[] produse = new Produs[NR_MAX_PRODUSE];
            using (StreamReader streamReader = new StreamReader(filePath))
            {
                string line;
                nrProduse = 0;
                while ((line = streamReader.ReadLine()) != null && nrProduse < NR_MAX_PRODUSE)
                {
                    produse[nrProduse++] = new Produs(line);
                }
            }
            return produse;
        }

        public Produs GetProdusAtIndex(int index)
        {
            string[] linii = File.ReadAllLines(filePath);
            if (index >= 0 && index < linii.Length)
            {
                return new Produs(linii[index]);
            }
            throw new Exception("Index invalid pentru produs.");
        }

        public bool UpdateProdus(int index, Produs produsActualizat)
        {
            try
            {
                string[] linii = File.ReadAllLines(filePath);

                if (index < 0 || index >= linii.Length)
                {
                    return false;
                }

                linii[index] = produsActualizat.ConversieLaSir_PentruFisier();
                File.WriteAllLines(filePath, linii);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Eroare la actualizarea produsului: {ex.Message}");
            }
        }
    }
}
