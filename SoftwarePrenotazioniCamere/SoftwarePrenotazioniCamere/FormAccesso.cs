using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaClassiPrenotazioneCamere;

namespace SoftwarePrenotazioniCamere
{
    public partial class FormAccesso : Form
    {
        public FormAccesso()
        {
            InitializeComponent();
        }

        Albergo albergoGirasole = new Albergo();
        private void btnAccedi_Click(object sender, EventArgs e)
        {
            bool available = false;

            foreach (Cliente c in albergoGirasole.Clienti)
            {
                if (boxNome.Text == c.Nome && boxCognome.Text == c.Cognome && boxPassword.Text == c.Password)
                {
                    available = true;
                }
            }

            if (available)
            {
                FormCatalogo formCatalogo = new FormCatalogo();
                formCatalogo.ShowDialog();
            }
        }
        private void btnIndietro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
