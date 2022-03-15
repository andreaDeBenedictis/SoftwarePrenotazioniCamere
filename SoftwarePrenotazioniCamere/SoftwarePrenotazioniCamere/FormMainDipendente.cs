using System.ComponentModel;
using System.Data;
using System.Text;
using LibreriaClassiPrenotazioneCamere;

namespace SoftwarePrenotazioniCamere
{
    public partial class FormMainDipendente : Form
    {
        //istanzazione oggetto "albergoGirasole"
        Albergo albergoGirasole = new Albergo();

        public FormMainDipendente()
        {
            InitializeComponent();
        }

        private void btnVisualizzaPrenotazioni_Click(object sender, EventArgs e)
        {
            listBoxVisualizzaSelezioni.DataSource = null;
            listBoxVisualizzaSelezioni.DataSource = albergoGirasole.Prenotazioni;
        }

        private void btnVisualizzaClienti_Click(object sender, EventArgs e)
        {
            listBoxVisualizzaSelezioni.DataSource = null;
            listBoxVisualizzaSelezioni.DataSource = albergoGirasole.Clienti;
        }

        private void btnVisualizzaDisponibilitàCamere_Click(object sender, EventArgs e)
        {
            listBoxVisualizzaSelezioni.DataSource = null;
            listBoxVisualizzaSelezioni.DataSource = albergoGirasole.Piano1;

            btnPiano1.Enabled = true;
            btnPiano2.Enabled = true;
            btnPiano3.Enabled = true;
        }

        private void btnPiano1_Click(object sender, EventArgs e)
        {
            listBoxVisualizzaSelezioni.DataSource = null;
            listBoxVisualizzaSelezioni.DataSource = albergoGirasole.Piano1;
        }

        private void btnPiano2_Click(object sender, EventArgs e)
        {
            listBoxVisualizzaSelezioni.DataSource = null;
            listBoxVisualizzaSelezioni.DataSource = albergoGirasole.Piano2;
        }

        private void btnPiano3_Click(object sender, EventArgs e)
        {
            listBoxVisualizzaSelezioni.DataSource = null;
            listBoxVisualizzaSelezioni.DataSource = albergoGirasole.Piano3;
        }

        private void comboCercaPer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            foreach (string cerca in listBoxVisualizzaSelezioni.Items)
            {
                if (cerca == boxRicerca.Text)
                {
                    listBoxVisualizzaSelezioni.DataSource = null;
                    listBoxVisualizzaSelezioni.Items.Add(cerca);
                }
            }
        }
    }
}
