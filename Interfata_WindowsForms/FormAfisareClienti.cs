using System;
using System.Windows.Forms;
using NivelStocareDate;
using SephoraClase;

namespace Interfata_WindowsForms
{
    public partial class FormAfisareClienti : Form
    {
        private AdministrareClient_FisierText adminClienti;

        // încarcă lista clienților din fișier
        public FormAfisareClienti()
        {
            InitializeComponent();
            adminClienti = new AdministrareClient_FisierText("clienti.txt");
            dataGridViewClienti.SelectionChanged += DataGridViewClienti_SelectionChanged;
            BtnModifica.Click += BtnModifica_Click;

            IncarcaClienti();
        }

        private void BtnAdaugaClient_Click(object sender, EventArgs e)
        {
            FormClienti form = new FormClienti();
            form.Show();
            this.Hide();
        }

        // Actualizează câmpurile text cu datele clientului selectat din tabel
        private void DataGridViewClienti_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewClienti.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewClienti.SelectedRows[0].Index;
                Client client = adminClienti.GetClient(selectedIndex);

                txtId.Text = client.IDClient.ToString();
                txtNume.Text = client.Nume;
                txtEmail.Text = client.Email;
                txtPreferinte.Text = client.Preferinte ?? "";
            }
        }

        // Buton: Modifică datele clientului selectat și actualizează fișierul
        private void BtnModifica_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtNume.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Completează toate câmpurile obligatorii!", "Atenție",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int id = int.Parse(txtId.Text);
                Client clientActualizat = new Client(id, txtNume.Text, txtEmail.Text, txtPreferinte.Text);
                bool succes = adminClienti.UpdateClient(clientActualizat);

                if (succes)
                {
                    MessageBox.Show("Client actualizat cu succes!", "Succes",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    IncarcaClienti();
                }
                else
                {
                    MessageBox.Show("Clientul nu a fost găsit!", "Eroare",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la actualizare: {ex.Message}", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InapoiA_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        // Buton: Caută clienți în funcție de termenul introdus și actualizează tabelul
        private void btnCautareA_Click(object sender, EventArgs e)
        {
            string termenCautare = txtCautareA.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(termenCautare))
            {
                MessageBox.Show("Introdu un termen de căutare!", "Atenție",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IncarcaClienti();
                return;
            }

            try
            {
                dataGridViewClienti.Rows.Clear();
                Client[] clienti;
                int nrClienti;
                clienti = adminClienti.GetClienti(out nrClienti);
                bool clientGasit = false;

                for (int i = 0; i < nrClienti; i++)
                {
                    Client client = clienti[i];
                    if (client.IDClient.ToString().Contains(termenCautare) ||
                        client.Nume.ToLower().Contains(termenCautare) ||
                        client.Email.ToLower().Contains(termenCautare) ||
                        (client.Preferinte != null && client.Preferinte.ToLower().Contains(termenCautare)))
                    {
                        dataGridViewClienti.Rows.Add(client.IDClient, client.Nume, client.Email, client.Preferinte);
                        clientGasit = true;
                    }
                }

                if (!clientGasit)
                {
                    MessageBox.Show("Niciun client găsit!", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Rezultatele au fost afișate în tabel!", "Succes",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la căutare: {ex.Message}", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Încarcă toți clienții din fișier în tabelul DataGridView
        private void IncarcaClienti()
        {
            try
            {
                dataGridViewClienti.Rows.Clear();
                Client[] clienti;
                int nrClienti;
                clienti = adminClienti.GetClienti(out nrClienti);

                for (int i = 0; i < nrClienti; i++)
                {
                    Client client = clienti[i];
                    dataGridViewClienti.Rows.Add(client.IDClient, client.Nume, client.Email, client.Preferinte);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la încărcarea clienților: {ex.Message}", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
