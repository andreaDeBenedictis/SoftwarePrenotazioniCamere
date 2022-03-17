using LibreriaClassiPrenotazioneCamere;

namespace SoftwarePrenotazioniCamere
{
    public partial class FormAccesso : Form
    {
        public FormAccesso()
        {
            InitializeComponent();
        }

        Albergo albergoGirasole = new Albergo();
        private void btnAccedi_Click(object sender, EventArgs e)
        {

            foreach (Cliente c in albergoGirasole.Clienti)
            {
                if (boxEmail.Text == c.Email && boxPassword.Text == c.Password)
                {
                    FormCatalogo formCatalogo = new FormCatalogo(c);
                    formCatalogo.ShowDialog();
                }
            }
        }
        private void btnIndietro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
