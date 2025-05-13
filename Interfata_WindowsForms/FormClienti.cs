using System;
using System.IO;
using System.Windows.Forms;
using SephoraClase;
using NivelStocareDate;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections.Generic;
using System.Linq;

namespace Interfata_WindowsForms
{
    public partial class FormClienti : Form
    {
        private AdministrareClient_FisierText adminClienti;

        public FormClienti()
        {
            InitializeComponent();
            adminClienti = new AdministrareClient_FisierText("clienti.txt");
        }

        private bool ValidareInput()
        {
            bool valid = true;
            errorProvider1.Clear();

            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;

            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                errorProvider1.SetError(txtId, "Id-ul este obligatoriu!");
                label4.Text = "Prenumele este obligatoriu!";
                label4.Visible = true;
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtNumeClient.Text))
            {
                errorProvider2.SetError(txtNumeClient, "Numele este obligatoriu!");
                label5.Text = "Numele este obligatoriu!";
                label5.Visible = true;
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider3.SetError(txtEmail, "Email este obligatoriu!");
                label6.Text = "Email nu a fost adăugată!";
                label6.Visible = true;
                valid = false;
            }

            return valid;
        }

        private bool ExistaClient(string id, string nume, string email)
        {
            try
            {
                if (!File.Exists("clienti.txt"))
                    return false;

                string[] linii = File.ReadAllLines("clienti.txt");
                foreach (string linie in linii)
                {
                    string[] date = linie.Split(',');
                    if (date.Length >= 3 &&
                        date[0].Trim() == id &&
                        date[1].Trim().Equals(nume, StringComparison.OrdinalIgnoreCase) &&
                        date[2].Trim().Equals(email, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la verificarea clientului: {ex.Message}", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

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

            if (ExistaClient(id.ToString(), nume, email))
            {
                MessageBox.Show("Există deja un client cu acest ID, nume și email!", "Atenție",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (StreamWriter sw = File.AppendText("clienti.txt"))
                {
                    sw.WriteLine($"{id},{nume},{email},{preferinteStr}");
                }

                MessageBox.Show("Client adăugat cu succes!", "Succes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtId.Clear();
                txtNumeClient.Clear();
                txtEmail.Clear();
                chkEmailNotifications.Checked = false;
                chkLoyaltyProgram.Checked = false;

                // Deschide FormAfisareClienti după adăugarea clientului
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
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}