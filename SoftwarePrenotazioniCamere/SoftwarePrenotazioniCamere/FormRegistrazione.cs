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
    public partial class FormRegistrazione : Form
    {
        public FormRegistrazione()
        {
            InitializeComponent();
        }

        private void FormRegistrazione_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrati_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente
                ( boxNome.Text,
                  boxCognome.Text,
                  boxCodiceFiscale.Text,
                  boxEmail.Text,
                  int.Parse(boxTelefono.Text)
                );

            FormCatalogo catalogo = new FormCatalogo();
            catalogo.ShowDialog();
        }

        private void btnAccedi_Click(object sender, EventArgs e)
        {
            FormAccesso formAccesso = new FormAccesso();
            formAccesso.ShowDialog();   
        }
    }
}
