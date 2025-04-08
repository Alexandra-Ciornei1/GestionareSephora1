using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using SephoraClase;

namespace Interfata_WindowsForms
{
    public partial class FormClienti : Form
    {
        private List<Client> clienti = new List<Client>();

        public FormClienti()
        {
            InitializeComponent();
            IncarcaClienti();
        }

        private void btnAdaugaClient_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("ID-ul trebuie să fie un număr întreg!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string nume = txtNumeClient.Text;
            string email = txtEmail.Text;

            if (string.IsNullOrEmpty(nume) || string.IsNullOrEmpty(nume) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Toate câmpurile sunt obligatorii!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Client client = new Client(id, nume, email);
            clienti.Add(client);
            ActualizeazaListaClienti();
            SalveazaClienti();
            MessageBox.Show("Client adăugat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtId.Clear();
            txtNumeClient.Clear();
            txtEmail.Clear();
        }

        private void ActualizeazaListaClienti()
        {
            listClienti.Items.Clear();
            foreach (var client in clienti)
            {
                listClienti.Items.Add($"ID: {client.IDClient}, Nume: {client.Nume}, Email: {client.Email}");
            }
        }

        private void SalveazaClienti()
        {
            using (StreamWriter sw = new StreamWriter("clienti.txt"))
            {
                foreach (var client in clienti)
                {
                    sw.WriteLine($"{client.IDClient},{client.Nume},{client.Email}");
                }
            }
        }

        private void IncarcaClienti()
        {
            try
            {
                if (File.Exists("clienti.txt"))
                {
                    foreach (string linie in File.ReadAllLines("clienti.txt"))
                    {
                        string[] parti = linie.Split(',');
                        if (int.TryParse(parti[0], out int id))
                        {
                            string nume = parti[1];
                            string email = parti[2];
                            clienti.Add(new Client { IDClient = id, Nume = nume, Email = email });
                        }
                    }
                    ActualizeazaListaClienti();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la încărcarea clienților: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}