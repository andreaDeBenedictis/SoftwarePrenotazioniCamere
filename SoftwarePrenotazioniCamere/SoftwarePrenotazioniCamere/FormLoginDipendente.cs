

namespace SoftwarePrenotazioniCamere
{
    public partial class FormLoginDipendente : Form
    {
        public FormLoginDipendente()
        {
            InitializeComponent();
            btnShow.BringToFront();
        }

        private void btnInvia_Click(object sender, EventArgs e)
        {
            lblErrore.Text = "";
            if (boxPassword.Text == "passwordSegreta")
            {
                boxPassword.Text = "";
                FormMainDipendente formDipendente = new FormMainDipendente();
                formDipendente.ShowDialog();
            }
            else
            {
                boxPassword.Text = "";
                lblErrore.Text = "Password sbagliata, riprovare...";
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (boxPassword.PasswordChar == '*')
            {
                btnHidden.BringToFront();
                boxPassword.PasswordChar = '\0';
            }
        }

        private void btnHidden_Click(object sender, EventArgs e)
        {
            if (boxPassword.PasswordChar == '\0')
            {
                btnShow.BringToFront();
                boxPassword.PasswordChar = '*';
            }
        }
    }
}
