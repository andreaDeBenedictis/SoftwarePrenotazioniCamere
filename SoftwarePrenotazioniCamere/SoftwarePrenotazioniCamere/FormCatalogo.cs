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
        Albergo albergoGirasole = new Albergo();
        List<Camera> camere = new List<Camera>();

        public FormCatalogo()
        {
            InitializeComponent();
            camere = albergoGirasole.RiempiListaCamere();
        }

        private void boxListaCamere_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPiano1_Click(object sender, EventArgs e)
        {
            boxListaCamere.Items.Clear();
            foreach (var c in camere)
            {
                if (c.Piano == 1) { boxListaCamere.Items.Add(c); }
            }
        }

        private void btnPiano2_Click(object sender, EventArgs e)
        {
            boxListaCamere.Items.Clear();
            foreach (var c in camere)
            {
                if (c.Piano == 2) { boxListaCamere.Items.Add(c); }
            }
        }

        private void btnPiano3_Click(object sender, EventArgs e)
        {
            boxListaCamere.Items.Clear();
            foreach (var c in camere)
            {
                if (c.Piano == 3) { boxListaCamere.Items.Add(c); }
            }
        }

        private void boxListaCamere_DoubleClick(object sender, EventArgs e)
        {
            foreach (var c in camere)
            {
                if (c.ToString() == boxListaCamere.SelectedItem.ToString())
                {
                    FormDettagliCamera dettagliCamere = new FormDettagliCamera(c);
                    dettagliCamere.ShowDialog();
                }
            }
        }
    }
}
