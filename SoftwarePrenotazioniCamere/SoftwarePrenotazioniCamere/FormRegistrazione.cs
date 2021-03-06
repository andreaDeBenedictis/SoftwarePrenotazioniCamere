using LibreriaClassiPrenotazioneCamere;

namespace SoftwarePrenotazioniCamere
{
    public partial class FormRegistrazione : Form
    {
        public FormRegistrazione()
        {
            InitializeComponent();
        }

        Albergo albergoGirasole = new Albergo();
        private void btnRegistrati_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente
                (boxNome.Text,
                  boxCognome.Text,
                  boxPassword.Text,
                  boxEmail.Text,
                  boxTelefono.Text
                );

            albergoGirasole.AggiungiCliente(c);


            if (CheckRegistrazione(c))
            {
                this.Close();
            }
        }

        public bool CheckRegistrazione(Cliente c)
        {
            bool available = true;
            foreach (string item in File.ReadLines(albergoGirasole.GetPathClienti()))
            {
                if (c.ToString() == item)
                {
                    available = false;
                }
            }

            if (available)
            {
                StreamWriter sw = File.AppendText(albergoGirasole.GetPathClienti());
                sw.WriteLine(c.ToString());
                sw.Close();
            }
            else
            {
                lblError.Text = "Stai provando a registrarti con un profilo già registrato";
                boxNome.Text = "";
                boxCognome.Text = "";
                boxPassword.Text = "";
                boxEmail.Text = "";
                boxTelefono.Text = "";
            }

            return available;
        }

        private void btnIndietro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
