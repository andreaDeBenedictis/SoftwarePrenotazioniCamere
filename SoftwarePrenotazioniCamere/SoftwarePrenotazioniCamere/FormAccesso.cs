using LibreriaClassiPrenotazioneCamere;

namespace SoftwarePrenotazioniCamere
{
    public partial class FormAccesso : Form
    {
        Albergo albergoGirasole = new Albergo();
        public FormAccesso(Albergo al)
        {
            InitializeComponent();
            albergoGirasole = al;
        }
        
        private void btnAccedi_Click(object sender, EventArgs e)
        {

            foreach (Cliente c in albergoGirasole.Clienti)
            {
                if (boxEmail.Text == c.Email && boxPassword.Text == c.Password)
                {
                    FormCatalogo formCatalogo = new FormCatalogo(c, albergoGirasole);
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
