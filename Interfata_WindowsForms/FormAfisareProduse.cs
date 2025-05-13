using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using NivelStocareDate;
using SephoraClase;

namespace Interfata_WindowsForms
{
    public partial class FormAfisareProduse : Form
    {
        private AdministrareProdus_FisierText adminProduse;
        private int selectedIndex = -1;

        public FormAfisareProduse()
        {
            InitializeComponent();
            adminProduse = new AdministrareProdus_FisierText("produse.txt");
            dataGridViewProduse.SelectionChanged += DataGridViewProduse_SelectionChanged;
            BtnModifica.Click += BtnModifica_Click;
            btnCautareA.Click += btnCautareA_Click;
            InapoiB.Click += InapoiB_Click;
            IncarcaProduse();
        }

        private void DataGridViewProduse_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewProduse.SelectedRows.Count > 0)
            {
                selectedIndex = dataGridViewProduse.SelectedRows[0].Index;
                Produs produs = adminProduse.GetProdusAtIndex(selectedIndex);

                txtNume.Text = produs.Nume;
                txtPret.Text = produs.Pret.ToString();
                txtCantitate.Text = produs.Cantitate;
                txtCategorie.Text = produs.CategorieProd.ToString();
            }
        }

        private void BtnModifica_Click(object sender, EventArgs e)
        {
            if (selectedIndex < 0)
            {
                MessageBox.Show("Selectează un produs pentru modificare!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtNume.Text) || string.IsNullOrEmpty(txtPret.Text) || string.IsNullOrEmpty(txtCantitate.Text))
            {
                MessageBox.Show("Completează toate câmpurile obligatorii!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                float pret = float.Parse(txtPret.Text);
                if (!new Produs().ValidarePret((int)pret))
                {
                    MessageBox.Show("Prețul trebuie să fie mai mare decât 0!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!Enum.TryParse(txtCategorie.Text, out Categorii categorie))
                {
                    MessageBox.Show("Categoria introdusă nu este validă!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Produs produsActualizat = new Produs(txtNume.Text, pret, txtCantitate.Text)
                {
                    CategorieProd = categorie
                };

                bool succes = adminProduse.UpdateProdus(selectedIndex, produsActualizat);

                if (succes)
                {
                    MessageBox.Show("Produs actualizat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    IncarcaProduse();
                }
                else
                {
                    MessageBox.Show("Eroare la actualizare!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la actualizare: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InapoiB_Click(object sender, EventArgs e)
        {
            FormProduse form = new FormProduse();
            form.Show();
            this.Close();
        }

        private void btnCautareA_Click(object sender, EventArgs e)
        {
            string termenCautare = txtCautareB.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(termenCautare))
            {
                MessageBox.Show("Introdu un termen de căutare!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IncarcaProduse();
                return;
            }

            try
            {
                // Asigurare coloane în DataGridView
                if (dataGridViewProduse.Columns.Count == 0)
                {
                    dataGridViewProduse.Columns.Add("Nume", "Nume");
                    dataGridViewProduse.Columns.Add("Pret", "Pret");
                    dataGridViewProduse.Columns.Add("Cantitate", "Cantitate");
                    dataGridViewProduse.Columns.Add("Categorie", "Categorie");
                }

                dataGridViewProduse.Rows.Clear();

                int nrProduse;
                Produs[] produse = adminProduse.GetProduse(out nrProduse);
                bool produsGasit = false;

                for (int i = 0; i < nrProduse; i++)
                {
                    Produs produs = produse[i];
                    if (produs == null) continue;

                    
                    if (
                        produs.Nume.ToLower().Contains(termenCautare) ||
                        produs.Pret.ToString().ToLower().Contains(termenCautare) ||
                        produs.Cantitate.ToLower().Contains(termenCautare) ||
                        produs.CategorieProd.ToString().ToLower().Contains(termenCautare)
                    )
                    {
                        dataGridViewProduse.Rows.Add(
                            produs.Nume,
                            produs.Pret.ToString(),
                            produs.Cantitate,
                            produs.CategorieProd.ToString()
                        );
                        produsGasit = true;
                    }
                }

                if (!produsGasit)
                {
                    MessageBox.Show("Niciun produs găsit!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Rezultatele au fost afișate!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la căutare: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void IncarcaProduse()
        {
            try
            {
                dataGridViewProduse.Rows.Clear();

                if (dataGridViewProduse.Columns.Count == 0)
                {
                    dataGridViewProduse.Columns.Add("Nume", "Nume");
                    dataGridViewProduse.Columns.Add("Pret", "Pret");
                    dataGridViewProduse.Columns.Add("Cantitate", "Cantitate");
                    dataGridViewProduse.Columns.Add("Categorie", "Categorie");
                }

                if (!File.Exists("produse.txt"))
                {
                    MessageBox.Show("Fișierul produse.txt nu există!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int nrProduse;
                Produs[] produse = adminProduse.GetProduse(out nrProduse);

                for (int i = 0; i < nrProduse; i++)
                {
                    if (produse[i] != null)
                    {
                        dataGridViewProduse.Rows.Add(
                            produse[i].Nume,
                            produse[i].Pret.ToString(),
                            produse[i].Cantitate,
                            produse[i].CategorieProd.ToString()
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la încărcarea produselor: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
