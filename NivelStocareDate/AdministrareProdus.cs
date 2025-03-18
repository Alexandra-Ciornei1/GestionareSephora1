using SephoraClase;
using System;
using System.Linq;

namespace NivelStocareDate
{
    public class AdministrareProdus
    {
        private const int NR_MAX_PRODUSE = 50;

        private Produs[] produse;
        private int nrProduse;

        public AdministrareProdus()
        {
            produse = new Produs[NR_MAX_PRODUSE];
            nrProduse = 0;
        }

        public void AddProdus(Produs produs)
        {
            if (nrProduse < produse.Length) 
            {
                produse[nrProduse] = produs;
                nrProduse++;
            }
            
        }

        public Produs[] GetProduse(out int nrProduse)
        {
            nrProduse = this.nrProduse;
            return produse.Take(nrProduse).ToArray(); 
        }

    }
}