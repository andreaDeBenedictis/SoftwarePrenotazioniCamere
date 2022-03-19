using LibreriaClassiPrenotazioneCamere;

namespace SoftwarePrenotazioniCamere
{
    public partial class FormMainDipendente : Form
    {
        //istanzazione oggetto "albergoGirasole"
        Albergo albergoGirasole = new Albergo();
        int tipoRicerca = 0;

        public FormMainDipendente()
        {
            InitializeComponent();
        }

        private void btnVisualizzaPrenotazioni_Click(object sender, EventArgs e)
        {
            tipoRicerca = 1;
            listBoxVisualizzaSelezioni.DataSource = null;

            List<string> stringList = new List<string>();

            foreach (Prenotazione prenotazione in albergoGirasole.Prenotazioni)
            {
                stringList.Add
                    (
                    $"Nome: {prenotazione.Cliente.Nome}   Cognome: {prenotazione.Cliente.Cognome}   Email: {prenotazione.Cliente.Email}   " + 
                    $"Password: {prenotazione.Cliente.Password}   N.Telefono: {prenotazione.Cliente.RecapitoTelefonico} " +
                    $"Data inizio: {prenotazione.DataInizio.Day}\\{prenotazione.DataInizio.Month}\\{prenotazione.DataInizio.Year}  " +
                    $"Data fine: {prenotazione.DataFine.Day}\\{prenotazione.DataFine.Month}\\{prenotazione.DataFine.Year}"
                    );
            }

            listBoxVisualizzaSelezioni.DataSource = stringList;
        }

        private void btnVisualizzaClienti_Click(object sender, EventArgs e)
        {
            tipoRicerca = 2;
            listBoxVisualizzaSelezioni.DataSource = null;
            List<string> stringList = new List<string>();

            foreach (Cliente c in albergoGirasole.Clienti)
            {
                stringList.Add("Nome: " + c.Nome + "   Cognome: " + c.Cognome + "   Email: " + c.Email + "   Password: " + c.Password + "   N.Telefono: " + c.RecapitoTelefonico);
            }

            listBoxVisualizzaSelezioni.DataSource = stringList;
        }

        private void btnVisualizzaDisponibilitàCamere_Click(object sender, EventArgs e)
        {
            tipoRicerca = 3;
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

        private void btnCerca_Click(object sender, EventArgs e)
        {
            foreach (var item in listBoxVisualizzaSelezioni.Items)
            {
                if (item.ToString() == boxRicerca.Text)
                {
                    listBoxVisualizzaSelezioni.Items.Remove(item);
                    listBoxVisualizzaSelezioni.Items.Add(item);
                }
            }
            switch (tipoRicerca)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    break;
            }
        }

        private void comboRicerca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
