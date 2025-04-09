using System;
using System.IO;
using System.Windows.Forms;
using NivelStocareDate;
using SephoraClase;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Interfata_WindowsForms
{
    public partial class FormProduse : Form
    {
        private AdministrareProdus_FisierText adminProduse;
        public FormProduse()
        {
            InitializeComponent();
            adminProduse = new AdministrareProdus_FisierText("produse.txt");
        }

        private void btnAdaugaProdus_Click(object sender, EventArgs e)
        {
            string nume = txtNumeProdus.Text;
            string pretText = txtPret.Text;
            string cantitateText = txtCantitate.Text;
            string categorie = comboCategorie.SelectedItem?.ToString();

            // Validare câmpuri
            if (string.IsNullOrEmpty(nume) || string.IsNullOrEmpty(pretText) ||
                string.IsNullOrEmpty(cantitateText) || string.IsNullOrEmpty(categorie))
            {
                MessageBox.Show("Toate câmpurile sunt obligatorii!", "Atenție",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validare numere
            if (!double.TryParse(pretText, out double pret) || !int.TryParse(cantitateText, out int cantitate))
            {
                MessageBox.Show("Prețul trebuie să fie un număr real, iar cantitatea un număr întreg!",
                    "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Salvare direct în fișier
            try
            {
                using (StreamWriter sw = File.AppendText("produse.txt"))
                {
                    sw.WriteLine($"{categorie},{nume},{pret}, {cantitate}");
                }

                // Resetare câmpuri
                txtNumeProdus.Clear();
                txtPret.Clear();
                txtCantitate.Clear();

                MessageBox.Show("Produs adăugat cu succes!", "Succes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la salvarea produsului: {ex.Message}",
                    "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInapoip_click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}