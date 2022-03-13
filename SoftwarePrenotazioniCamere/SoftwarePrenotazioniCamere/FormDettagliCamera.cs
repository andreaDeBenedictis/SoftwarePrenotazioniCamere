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
    public partial class FormDettagliCamera : Form
    {
        public FormDettagliCamera(Camera camera)
        {
            InitializeComponent();
            lblPiano.Text = camera.Piano.ToString();
            lblNumero.Text = camera.Numero.ToString();
        }

        private void btnIndietro_Click(object sender, EventArgs e)
        {

        }

        private void Calendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            
        }

        private void btnSelDa_Click(object sender, EventArgs e)
        {
            string[] data = Calendario.SelectionRange.Start.ToShortDateString().Split("/");

            lblDataDa.Text = data[0] + "/" + data[1];
            ControlloData();
        }

        private void btnSelA_Click(object sender, EventArgs e)
        {
            string[] data = Calendario.SelectionRange.Start.ToShortDateString().Split("/");

            lblDataA.Text = data[0] + "/" + data[1];

            ControlloData();
        }

        public void ControlloData()
        {
            try
            {
                string[] date1 = lblDataDa.Text.Split("/");
                string[] date2 = lblDataA.Text.Split("/");

                int mese1 = int.Parse(date1[0]);
                int mese2 = int.Parse(date2[0]);

                int giorno1 = int.Parse(date1[1]);
                int giorno2 = int.Parse(date2[1]);

                if (mese1 > mese2)
                {
                    lblErrore.Text = "Non è possibile eseguire la prenotazione per le date appena inserite";
                    lblDataDa.Text = "Da";
                    lblDataA.Text = "A";
                }
                else if (mese1 == mese2 && giorno1 >= giorno2)
                {
                    lblErrore.Text = "Non è possibile eseguire la prenotazione per le date appena inserite";
                    lblDataDa.Text = "Da";
                    lblDataA.Text = "A";
                }
            }
            catch (Exception)
            {

            }
            
        }
    }
}
