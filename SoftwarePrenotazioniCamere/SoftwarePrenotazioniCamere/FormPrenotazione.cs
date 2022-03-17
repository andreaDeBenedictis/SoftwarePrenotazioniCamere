using LibreriaClassiPrenotazioneCamere;

namespace SoftwarePrenotazioniCamere
{
    public partial class FormPrenotazione : Form
    {
        Albergo albergoGirasole = new Albergo();
        Camera camera;
        Cliente cliente;

        public FormPrenotazione(Camera c, Cliente cliente)
        {
            InitializeComponent();
            camera = c;
            this.cliente = cliente;
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

            listBoxPrezzi.Items.Add("Prezzo base: " + camera.Prezzo + "€");

            lblPrezzoTotale.Text = camera.Prezzo + "€";
        }

        public void ControlloData()
        {
            try
            {
                int annoDa = dataPickerDa.Value.Year;
                int annoA = dataPickerA.Value.Year;

                int meseDa = dataPickerDa.Value.Month;
                int meseA = dataPickerA.Value.Month;

                int giornoDa = dataPickerDa.Value.Day;
                int giornoA = dataPickerA.Value.Day;

                if (meseDa > meseA)
                {
                    lblErrore.Text = "Non è possibile eseguire la prenotazione per le date appena inserite";
                    dataPickerDa.Value = DateTime.Today;
                    dataPickerA.Value = DateTime.Today;
                }
                else if (meseDa == meseA && giornoDa >= giornoA)
                {
                    lblErrore.Text = "Non è possibile eseguire la prenotazione per le date appena inserite";
                    dataPickerDa.Value = DateTime.Today;
                    dataPickerA.Value = DateTime.Today;
                }
                else if (annoDa != annoA)
                {
                    lblErrore.Text = "Non è possibile eseguire la prenotazione per le date appena inserite";
                    dataPickerDa.Value = DateTime.Today;
                    dataPickerA.Value = DateTime.Today;
                }
            }
            catch (Exception)
            {

            }

        }

        private void btnIndietro_Click(object sender, EventArgs e)
        {
            camera.PrezzoBase();
            Close(); 
        }

        private void checkedListBoxServizi_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            foreach (Servizio s in camera.Servizi)
            {
                
                if (checkedListBoxServizi.SelectedItem.ToString() == s.ToString())
                {
                    if (ControllaListPrezzi(s))
                    {
                        listBoxPrezzi.Items.Add($"{s.NomeServizio}: + {s.Prezzo}€");
                        camera.Prezzo += s.Prezzo;
                        s.Attivazione = true;
                    } 
                }
                
            }
            lblPrezzoTotale.Text = camera.Prezzo + "€";
        }

        private void btnPrenota_Click(object sender, EventArgs e)
        {
            Prenotazione prenotazione = new Prenotazione(cliente, camera, dataPickerDa.Value, dataPickerA.Value);
            albergoGirasole.AggiungiPrenotazione(prenotazione);

            StreamWriter sw = File.AppendText(albergoGirasole.GetPathPrenotazioni());
            sw.WriteLine(prenotazione.ToString());
            sw.Close();

            Close();
        }

        private bool ControllaListPrezzi(Servizio s)
        {
            for (int i = 0; i < listBoxPrezzi.Items.Count; i++)
            {
                if (listBoxPrezzi.Items[i].ToString() == $"{s.NomeServizio}: + {s.Prezzo}€")
                {
                    listBoxPrezzi.Items.RemoveAt(i);
                    camera.Prezzo -= s.Prezzo;
                    s.Attivazione = false;
                    return false;
                }
            }

            return true;
        }

        private void dataPickerDa_ValueChanged(object sender, EventArgs e)
        {
            ControlloData();
        }

        private void dataPickerA_ValueChanged(object sender, EventArgs e)
        {
            ControlloData();
        }
    }
    
}
