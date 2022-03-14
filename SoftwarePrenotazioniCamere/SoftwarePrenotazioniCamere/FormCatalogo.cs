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
            RiempimentoListaCamere();
            boxListaCamere.Enabled = false;
        }

        private void boxListaCamere_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPiano1_Click(object sender, EventArgs e)
        {
            boxListaCamere.Enabled = true;
            boxListaCamere.DataSource = null;
            boxListaCamere.DataSource = albergoGirasole.Piano1;
        }

        private void btnPiano2_Click(object sender, EventArgs e)
        {
            boxListaCamere.Enabled = true;
            boxListaCamere.DataSource = null;
            boxListaCamere.DataSource = albergoGirasole.Piano2;
        }

        private void btnPiano3_Click(object sender, EventArgs e)
        {
            boxListaCamere.Enabled = true;
            boxListaCamere.DataSource = null;
            boxListaCamere.DataSource = albergoGirasole.Piano3;
        }

        private void boxListaCamere_DoubleClick(object sender, EventArgs e)
        {
                foreach (Camera c in camere)
                {
                    if (c.ToString() == boxListaCamere.SelectedItem.ToString())
                    {
                        FormPrenotazione dettagliCamere = new FormPrenotazione(c);
                        dettagliCamere.ShowDialog();
                    }
                }
        }

        private void RiempimentoListaCamere()
        {
            foreach (Camera c in albergoGirasole.Piano1)
            {
                camere.Add(c);
            }

            foreach (Camera c in albergoGirasole.Piano2)
            {
                camere.Add(c);
            }

            foreach (Camera c in albergoGirasole.Piano3)
            {
                camere.Add(c);
            }
        }

    }
}
