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
    public partial class FormPrenotazione : Form
    {
        Albergo albergoGirasole = new Albergo();
        Camera camera;
        
        public FormPrenotazione(Camera c)
        {
            InitializeComponent();
            camera = c;
        }

        private void FormPrenotazione_Load(object sender, EventArgs e)
        {
            lblPiano.Text = camera.Piano.ToString();
            lblNumero.Text = camera.Numero.ToString();
            if (camera.Tipo) lblTipologia.Text = "Singola";
            else lblTipologia.Text = "Doppia";
            lblPrezzoPerNotte.Text = camera.Prezzo + "€";
            lblDescrizione.Text = camera.Descrizione.ToString();

            checkedListBoxServizi.DataSource = null;
            checkedListBoxServizi.DataSource = camera.Servizi;
        }

        private void btnSelDa_Click_1(object sender, EventArgs e)
        {
            string[] data = Calendario.SelectionRange.Start.ToShortDateString().Split("/");

            lblDataDa.Text = data[0] + "/" + data[1];
            ControlloData();
        }

        private void btnSelA_Click_1(object sender, EventArgs e)
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

        private void btnIndietro_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBoxServizi_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            foreach(Servizio s in camera.Servizi)
            {
                if(checkedListBoxServizi.SelectedItem.ToString() == s.ToString())
                {
                    listBoxPrezzi.Items.Add($"{s.NomeServizio}: + {s.Prezzo}€");
                }
                for(int i = 0; i < listBoxPrezzi.Items.Count; i++)
                {
                    if(listBoxPrezzi.Items.Contains(i).ToString() == $"{s.NomeServizio}: + {s.Prezzo}€")
                    {
                        listBoxPrezzi.Items.Remove(i);
                    }
                }
            }
        }
    }
}
