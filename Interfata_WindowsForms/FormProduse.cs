using System;
using System.IO;
using System.Reflection.Emit;
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
        private bool ValidareInput()
        {
            bool valid = true;
            errorNume.Clear();

            labelNume.Visible = false;
            labelPret.Visible = false;
            labelCantitate.Visible = false;
            labelCategorie.Visible = false;

            if (string.IsNullOrWhiteSpace(txtNumeProdus.Text))
            {
                errorNume.SetError(txtNumeProdus, "Numele este obligatoriu!");
                labelNume.Text = "Numele este obligatoriu!";
                labelNume.Visible = true;
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtPret.Text))
            {
                errorPret.SetError(txtPret, "Pretul este obligatoriu!");
                labelPret.Text = "Pretul este obligatoriu!";
                labelPret.Visible = true;
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtCantitate.Text))
            {
                errorCantitate.SetError(txtCantitate, "Cantitatea este obligatorie!");
                labelCantitate.Text = "Cantitatea nu a fost adăugată!";
                labelCantitate.Visible = true;
                valid = false;
            }
            if (!rdbMachiaj.Checked && !rdbSkinCare.Checked && !rdbParfum.Checked &&
        !rdbBodycare.Checked && !rdbPar.Checked && !rdbAccesorii.Checked && !rdbKorean.Checked)
            {
                labelCategorie.Text = "Selectați o categorie!";
                labelCategorie.Visible = true;
                valid = false;
            }

            return valid;
        }
        private bool ExistaProdus(string categorie, string nume, string pret, string cantitate)
        {
            try
            {
                if (!File.Exists("produse.txt"))
                    return false;

                string[] linii = File.ReadAllLines("produse.txt");
                foreach (string linie in linii)
                {
                    string[] date = linie.Split(',');
                    if (date.Length == 4 &&
                        date[0].Trim().Equals(categorie, StringComparison.OrdinalIgnoreCase) &&
                        date[1].Trim().Equals(nume, StringComparison.OrdinalIgnoreCase) &&
                        date[2].Trim() == pret &&
                        date[3].Trim() == cantitate)
                    {
                        return true; // Produsul există deja
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la verificarea produsului: {ex.Message}", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        private void btnAdaugaProdus_Click(object sender, EventArgs e)
        {
            if (!ValidareInput())
            {
                // Dacă validarea eșuează, ieșim din metodă
                return;
            }
            string nume = txtNumeProdus.Text;
            string pretText = txtPret.Text;
            string cantitateText = txtCantitate.Text;
            string categorie = GetCategorieSelectata().ToString();

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
            if (ExistaProdus(categorie, nume, pretText, cantitateText))
            {
                MessageBox.Show("Există deja un produs cu această categorie, nume, preț și cantitate!", "Atenție",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Salvare direct în fișier
            try
            {
                using (StreamWriter sw = File.AppendText("produse.txt"))
                {
                    sw.WriteLine($"{nume},{pret},{cantitate},{categorie}"); // Corectare ordine câmpuri
                }

                // Resetare câmpuri
                txtNumeProdus.Clear();
                txtPret.Clear();
                txtCantitate.Clear();

                MessageBox.Show("Produs adăugat cu succes!", "Succes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Deschide FormAfisareProduse
                FormAfisareProduse formAfisare = new FormAfisareProduse();
                formAfisare.Show();
                this.Close(); // Închide FormProduse
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la salvarea produsului: {ex.Message}",
                    "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Categorii GetCategorieSelectata()
        {
            if (rdbMachiaj.Checked)
                return Categorii.Machiaj;
            if (rdbSkinCare.Checked)
                return Categorii.Skincare;
            if (rdbParfum.Checked)
                return Categorii.Parfumuri;
            if (rdbBodycare.Checked)
                return Categorii.Bodycare;
            if (rdbPar.Checked)
                return Categorii.Par;
            if (rdbAccesorii.Checked)
                return Categorii.Accesorii;
            if (rdbKorean.Checked)
                return Categorii.KoreanBeauty;
            return Categorii.Machiaj;
        }
        private void btnInapoip_click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
       
        
    }
}