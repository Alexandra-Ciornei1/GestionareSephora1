using System;
using System.Collections.Generic;
using System.IO;
using SephoraClase;

namespace NivelStocareDate
{
    public class AdministrareProdus_FisierText
    {
        private string filePath;

        public AdministrareProdus_FisierText(string filePath)
        {
            this.filePath = filePath;
            // se incearca deschiderea fisierului in modul OpenOrCreate
            // astfel incat sa fie creat daca nu exista
            Stream streamFisierText = File.Open(filePath, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddProdus(Produs produs)
        {
            // Check if the product already exists in the file
            var produse = GetProduse(out int nrProduse);
            foreach (var p in produse)
            {
                if (p.Nume == produs.Nume && p.Pret == produs.Pret && p.Cantitate == produs.Cantitate)
                {
                    Console.WriteLine("Product already exists in the file.");
                    return;
                }
            }

            // If the product does not exist, add it to the file
            using (StreamWriter streamWriterFisierText = new StreamWriter(filePath, true))
            {
                streamWriterFisierText.WriteLine(produs.ToString());
            }
        }

        public Produs[] GetProduse(out int nrProduse)
        {
            List<Produs> produse = new List<Produs>();
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                nrProduse = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    produse.Add(new Produs(line));
                    nrProduse++;
                }
            }
           // nrProduse = produse.Count;
            return produse.ToArray();
        }
    }
}
