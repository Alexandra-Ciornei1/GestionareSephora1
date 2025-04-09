using System;
using System.IO;
using System.Windows.Forms;
using SephoraClase;
using NivelStocareDate;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;

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
        private void btnAdaugaClient_Click(object sender, EventArgs e)
        {
            if (!ValidareInput())
            {
                // Dacă validarea eșuează, ieșim din metodă
                return;
            }
            // Validare ID
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("ID-ul trebuie să fie un număr întreg!", "Atenție",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validare câmpuri obligatorii
            string nume = txtNumeClient.Text;
            string email = txtEmail.Text;
            if (string.IsNullOrEmpty(nume) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Numele și emailul sunt obligatorii!", "Atenție",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Salvare direct în fișier
            try
            {
                using (StreamWriter sw = File.AppendText("clienti.txt"))
                {
                    sw.WriteLine($"{id},{nume},{email}");
                }

                // Resetare câmpuri
                txtId.Clear();
                txtNumeClient.Clear();
                txtEmail.Clear();

                MessageBox.Show("Client adăugat cu succes!", "Succes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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