using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using SephoraClase;

namespace Interfata_WindowsForms
{
    public partial class FormProduse : Form
    {
        private List<(string Categorie, Produs Produs)> produse = new List<(string, Produs)>();

        public FormProduse()
        {
            InitializeComponent();
            IncarcaProduse();
        }

        private void btnAdaugaProdus_Click(object sender, EventArgs e)
        {
            string nume = txtNumeProdus.Text;
            string pretText = txtPret.Text;
            string cantitateText = txtCantitate.Text;
            string categorie = comboCategorie.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(nume) || string.IsNullOrEmpty(pretText) || string.IsNullOrEmpty(cantitateText) || string.IsNullOrEmpty(categorie))
            {
                MessageBox.Show("Toate câmpurile sunt obligatorii!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (double.TryParse(pretText, out double pret) && int.TryParse(cantitateText, out int cantitate))
            {
                Produs produs = new Produs(nume, (int)pret, cantitate.ToString());
                produse.Add((categorie, produs));
                ActualizeazaListaProduse();
                SalveazaProduse();
                MessageBox.Show("Produs adăugat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumeProdus.Clear();
                txtPret.Clear();
                txtCantitate.Clear();
            }
            else
            {
                MessageBox.Show("Prețul trebuie să fie un număr real, iar cantitatea un număr întreg!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizeazaListaProduse()
        {
            listProduse.Items.Clear();
            foreach (var (categorie, produs) in produse)
            {
                listProduse.Items.Add($"{categorie}: {produs.Nume} - {produs.Pret} RON - {produs.Cantitate} buc");
            }
        }

        private void SalveazaProduse()
        {
            using (StreamWriter sw = new StreamWriter("produse.txt"))
            {
                foreach (var (categorie, produs) in produse)
                {
                    sw.WriteLine($"{categorie},{produs.Nume},{produs.Pret},{produs.Cantitate}");
                }
            }
        }

        private void IncarcaProduse()
        {
            try
            {
                if (File.Exists("produse.txt"))
                {
                    foreach (string linie in File.ReadAllLines("produse.txt"))
                    {
                        string[] parti = linie.Split(',');
                        string categorie = parti[0];
                        string nume = parti[1];
                        double pret = double.Parse(parti[2]);
                        int cantitate = int.Parse(parti[3]);
                        produse.Add((categorie, new Produs(nume, (int)pret, cantitate.ToString())));
                    }
                    ActualizeazaListaProduse();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la încărcarea produselor: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}