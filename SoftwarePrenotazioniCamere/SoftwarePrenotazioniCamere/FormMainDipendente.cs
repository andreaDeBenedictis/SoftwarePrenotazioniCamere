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

            SetNomeListaPrenotazioni(stringList);

            listBoxVisualizzaSelezioni.DataSource = stringList;
        }

        private void btnVisualizzaClienti_Click(object sender, EventArgs e)
        {
            tipoRicerca = 2;
            listBoxVisualizzaSelezioni.DataSource = null;
            List<string> stringList = new List<string>();

            SetNomeListaClienti(stringList);

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

        public void SetNomeListaClienti(List<string> list)
        {
            foreach (Cliente c in albergoGirasole.Clienti)
            {
                list.Add("Nome: " + c.Nome + "   Cognome: " + c.Cognome + "   Email: " + c.Email + "   Password: " + c.Password + "   N.Telefono: " + c.RecapitoTelefonico);
            }
        }

        public void SetNomeListaPrenotazioni(List<string> list)
        {
            foreach (Prenotazione p in albergoGirasole.Prenotazioni)
            {
                list.Add
                    (
                    $"Nome: {p.Cliente.Nome}   Cognome: {p.Cliente.Cognome}   Email: {p.Cliente.Email}   " +
                    $"Password: {p.Cliente.Password}   N.Telefono: {p.Cliente.RecapitoTelefonico} " +
                    $"Data inizio: {p.DataInizio.Day}\\{p.DataInizio.Month}\\{p.DataInizio.Year}  " +
                    $"Data fine: {p.DataFine.Day}\\{p.DataFine.Month}\\{p.DataFine.Year}"
                    );
            }
        }
    }
}
