using System;
using System.Windows.Forms;
using SephoraClase;
using NivelStocareDate;
using System.Collections.Generic;
using System.Linq;

namespace Interfata_WindowsForms
{
    public partial class FormClienti : Form
    {
        private AdministrareClient_FisierText adminClienti;

        // Inițializează formularul pentru adăugarea unui client nou
        public FormClienti()
        {
            InitializeComponent();
            adminClienti = new AdministrareClient_FisierText("clienti.txt");
            btnAdaugaClient.Click += btnAdaugaClient_Click;
            btnInapoi.Click += btnInapoi_click;
        }

        // Validează câmpurile de intrare și afișează erori dacă este cazul
        private bool ValidareInput()
        {
            bool valid = true;
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();

            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                errorProvider1.SetError(txtId, "Id-ul este obligatoriu!");
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtNumeClient.Text))
            {
                errorProvider2.SetError(txtNumeClient, "Numele este obligatoriu!");
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider3.SetError(txtEmail, "Email este obligatoriu!");
                valid = false;
            }

            return valid;
        }

        // Buton: Adaugă un client nou în fișier și revine la formularul de afișare clienți
        private void btnAdaugaClient_Click(object sender, EventArgs e)
        {
            if (!ValidareInput())
                return;

            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("ID-ul trebuie să fie un număr întreg!", "Atenție",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nume = txtNumeClient.Text;
            string email = txtEmail.Text;
            List<string> preferinte = new List<string>();
            if (chkEmailNotifications.Checked) preferinte.Add("Notificari Email");
            if (chkLoyaltyProgram.Checked) preferinte.Add("Program de loialitate");
            string preferinteStr = preferinte.Any() ? string.Join(";", preferinte) : "";

            try
            {
                Client client = new Client(id, nume, email, preferinteStr);
                adminClienti.AddClient(client);

                MessageBox.Show("Client adăugat cu succes!", "Succes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtId.Clear();
                txtNumeClient.Clear();
                txtEmail.Clear();
                chkEmailNotifications.Checked = false;
                chkLoyaltyProgram.Checked = false;

                FormAfisareClienti form = new FormAfisareClienti();
                form.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la salvarea clientului: {ex.Message}", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInapoi_click(object sender, EventArgs e)
        {
            FormAfisareClienti form = new FormAfisareClienti();
            form.Show();
            this.Hide();
        }
    }
}
