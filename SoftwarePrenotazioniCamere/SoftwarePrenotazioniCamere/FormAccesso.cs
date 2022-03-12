using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwarePrenotazioniCamere
{
    public partial class FormAccesso : Form
    {
        public FormAccesso()
        {
            InitializeComponent();
        }

        private void btnRegistrati_Click(object sender, EventArgs e)
        {
            FormRegistrazione formRegistrazione = new FormRegistrazione();
            formRegistrazione.ShowDialog();
        }

        private void btnAccedi_Click(object sender, EventArgs e)
        {
            OpenFileDialog listaClienti = new OpenFileDialog();

            FormCatalogo formCatalogo = new FormCatalogo();
            formCatalogo.ShowDialog();
        }
    }
}
