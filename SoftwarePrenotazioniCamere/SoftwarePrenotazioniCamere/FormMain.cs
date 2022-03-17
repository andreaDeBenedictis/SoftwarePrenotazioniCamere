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
            FormAccesso formAccesso = new FormAccesso();
            formAccesso.ShowDialog();
        }

        private void btnRegistrati_Click(object sender, EventArgs e)
        {
            FormRegistrazione formRegistrazione = new FormRegistrazione();
            formRegistrazione.ShowDialog();
        }
    }
}