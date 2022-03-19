using LibreriaClassiPrenotazioneCamere;

namespace SoftwarePrenotazioniCamere
{
    public partial class FormCatalogo : Form
    {
        Albergo albergoGirasole = new Albergo();

        List<Camera> camere = new List<Camera>();

        Cliente cliente;

        public FormCatalogo(Cliente c)
        {
            InitializeComponent();
            RiempimentoListaCamere(); // riempie una lista delle camere con le 3 liste dei piani
            cliente = c;
        }

        private void FormCatalogo_Load(object sender, EventArgs e) // carica nella lista le camere del primo piano
        {
            boxListaCamere.DataSource = null;
            boxListaCamere.DataSource = albergoGirasole.Piano1;
        }

        private void boxListaCamere_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPiano1_Click(object sender, EventArgs e) // carica le camere del primo piano
        {
            boxListaCamere.DataSource = null;
            boxListaCamere.DataSource = albergoGirasole.Piano1;
        }

        private void btnPiano2_Click(object sender, EventArgs e) // carica le camere del secondo piano
        {
            boxListaCamere.DataSource = null;
            boxListaCamere.DataSource = albergoGirasole.Piano2;
        }

        private void btnPiano3_Click(object sender, EventArgs e) // carica le camere del terzo piano
        {
            boxListaCamere.DataSource = null;
            boxListaCamere.DataSource = albergoGirasole.Piano3;
        }

        private void boxListaCamere_DoubleClick(object sender, EventArgs e) // apre la form Prenotazione della camera selezionata
        {
            foreach (Camera c in camere)
            {
                if (c.ToString() == boxListaCamere.SelectedItem.ToString())
                {
                    FormPrenotazione dettagliCamere = new FormPrenotazione(c, cliente);
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
