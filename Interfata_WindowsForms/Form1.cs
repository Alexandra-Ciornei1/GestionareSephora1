using System;
using System.Windows.Forms;

namespace Interfata_WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProduse_Click(object sender, EventArgs e)
        {
            FormProduse formProduse = new FormProduse();
            formProduse.ShowDialog(); // Deschide formularul pentru produse
            this.Hide(); // Ascunde formularul curent
        }

        private void btnClienti_Click(object sender, EventArgs e)
        {
            FormClienti formClienti = new FormClienti();
            formClienti.ShowDialog(); // Deschide formularul pentru clienți
            this.Hide(); // Ascunde formularul curent
        }

       
    }
}