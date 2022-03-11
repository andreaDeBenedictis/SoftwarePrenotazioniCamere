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
    public partial class FormLoginDipendente : Form
    {
        public FormLoginDipendente()
        {
            InitializeComponent();
        }

        private void btnInvia_Click(object sender, EventArgs e)
        {
            lblErrore.Text = "";
            if (boxPassword.Text == "passwordSegreta")
            {
                boxPassword.Text = "";
                FormMainDipendente formDipendente = new FormMainDipendente();
                formDipendente.ShowDialog();
            }
            else
            {
                boxPassword.Text = "";
                lblErrore.Text = "Password sbagliata, riprovare...";
            }
        }
    }
}
