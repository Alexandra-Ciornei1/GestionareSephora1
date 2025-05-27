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
            FormAfisareProduse formAfisareProduse = new FormAfisareProduse();
            formAfisareProduse.ShowDialog();
            this.Hide();
        }


        private void btnClienti_Click(object sender, EventArgs e)
        {
            FormAfisareClienti formAfisareClienti = new FormAfisareClienti();
            formAfisareClienti.ShowDialog();
            this.Hide();
        }
    }
}