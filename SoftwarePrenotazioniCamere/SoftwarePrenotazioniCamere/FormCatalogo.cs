using LibreriaClassiPrenotazioneCamere;

namespace SoftwarePrenotazioniCamere
{
    public partial class FormCatalogo : Form
    {
        Albergo albergoGirasole;

        Cliente cliente;

        public FormCatalogo(Cliente c, Albergo al)
        {
            InitializeComponent();
            
            cliente = c;
            albergoGirasole = al;
        }

        private void FormCatalogo_Load(object sender, EventArgs e) // carica nella lista le camere del primo piano
        {
            foreach(Camera cam in albergoGirasole.Camere)
            {
                if (!cam.Disponibilità && cam.Piano == 1)
                {
                    boxListaCamere.Items.Add(cam);
                }
            }
        }

        private void boxListaCamere_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPiano1_Click(object sender, EventArgs e) // carica le camere del primo piano
        {
            boxListaCamere.Items.Clear();

            foreach (Camera cam in albergoGirasole.Camere)
            {
                if (!cam.Disponibilità && cam.Piano == 1)
                {
                    boxListaCamere.Items.Add(cam);
                }
            }
        }

        private void btnPiano2_Click(object sender, EventArgs e) // carica le camere del secondo piano
        {
            boxListaCamere.Items.Clear();

            foreach (Camera cam in albergoGirasole.Camere)
            {
                if (!cam.Disponibilità && cam.Piano == 2)
                {
                    boxListaCamere.Items.Add(cam);
                }
            }
        }

        private void btnPiano3_Click(object sender, EventArgs e) // carica le camere del terzo piano
        {
            boxListaCamere.Items.Clear();

            foreach (Camera cam in albergoGirasole.Camere)
            {
                if (!cam.Disponibilità && cam.Piano == 3)
                {
                    boxListaCamere.Items.Add(cam);
                }
            }
        }

        private void boxListaCamere_DoubleClick(object sender, EventArgs e) // apre la form Prenotazione della camera selezionata
        {
            foreach (Camera c in albergoGirasole.Camere)
            {
                if (c.ToString() == boxListaCamere.SelectedItem.ToString())
                {
                    FormPrenotazione dettagliCamere = new FormPrenotazione(c, cliente);
                    dettagliCamere.ShowDialog();
                }
            }
        }

        


    }
}
