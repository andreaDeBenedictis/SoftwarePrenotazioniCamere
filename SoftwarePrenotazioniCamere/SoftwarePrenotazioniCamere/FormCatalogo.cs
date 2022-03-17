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
            RiempimentoListaCamere();
            boxListaCamere.Enabled = false;
            cliente = c;
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
