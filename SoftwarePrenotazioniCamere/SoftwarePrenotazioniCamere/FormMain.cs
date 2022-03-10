namespace SoftwarePrenotazioniCamere
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnMainDipendente_Click(object sender, EventArgs e)
        {
            FormLoginDipendente loginDipendente = new FormLoginDipendente();
            loginDipendente.ShowDialog();
        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            FormCatalogo catalogo = new FormCatalogo();
            catalogo.ShowDialog();
        }
    }
}