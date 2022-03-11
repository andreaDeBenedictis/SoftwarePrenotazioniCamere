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
            boxListaCamere.Items.Clear();
            boxListaCamere.DataSource = null;
            foreach (Camera c in albergoGirasole.Piano1)
            {
                boxListaCamere.Items.Add(c.GetInfo());
            }
        }

        private void btnPiano2_Click(object sender, EventArgs e)
        {
            boxListaCamere.Items.Clear();
            boxListaCamere.DataSource = null;
            foreach (Camera c in albergoGirasole.Piano2)
            {
                boxListaCamere.Items.Add(c.GetInfo());
            }
        }

        private void btnPiano3_Click(object sender, EventArgs e)
        {
            boxListaCamere.Items.Clear();
            boxListaCamere.DataSource = null;
            foreach (Camera c in albergoGirasole.Piano3)
            {
                boxListaCamere.Items.Add(c.GetInfo());
            }
        }
    }
}
