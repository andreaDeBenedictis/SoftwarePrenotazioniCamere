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
        List<Camera> camere = new List<Camera>();

        public FormMainDipendente()
        {
            InitializeComponent();
            camere = albergoGirasole.RiempiListaCamere();
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
            listBoxVisualizzaSelezioni.Items.Clear();
            foreach (var c in camere)
            {
                if (c.Piano < 200) { listBoxVisualizzaSelezioni.Items.Add(c); }
            }

            btnPiano1.Enabled = true;
            btnPiano2.Enabled = true;
            btnPiano3.Enabled = true;
        }

        private void btnPiano1_Click(object sender, EventArgs e)
        {
            listBoxVisualizzaSelezioni.Items.Clear();
            foreach (var c in camere)
            {
                if (c.Piano < 200) { listBoxVisualizzaSelezioni.Items.Add(c); }
            }
        }

        private void btnPiano2_Click(object sender, EventArgs e)
        {
            listBoxVisualizzaSelezioni.Items.Clear();
            foreach (var c in camere)
            {
                if (c.Piano < 300 && c.Piano >= 200) listBoxVisualizzaSelezioni.DataSource = c.Piano;
            }
        }

        private void btnPiano3_Click(object sender, EventArgs e)
        {
            listBoxVisualizzaSelezioni.Items.Clear();
            foreach (var c in camere)
            {
                if (c.Piano >= 300) listBoxVisualizzaSelezioni.DataSource = c.Piano;
            }
        }
    }
}
