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
    public partial class FormCatalogo : Form
    {
        public FormCatalogo()
        {
            InitializeComponent();
        }

        private void boxListaCamere_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        Albergo albergoGirasole = new Albergo();

        private void btnPiano1_Click(object sender, EventArgs e)
        {
            boxListaCamere.DataSource = null;
            boxListaCamere.DataSource = albergoGirasole.Piano1;
        }

        private void btnPiano2_Click(object sender, EventArgs e)
        {
            boxListaCamere.DataSource = null;
            boxListaCamere.DataSource = albergoGirasole.Piano2;
        }

        private void btnPiano3_Click(object sender, EventArgs e)
        {
            boxListaCamere.DataSource = null;
            boxListaCamere.DataSource = albergoGirasole.Piano3;
        }
    }
}
