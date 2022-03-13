using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaClassiPrenotazioneCamere;

namespace SoftwarePrenotazioniCamere
{
    public partial class FormRegistrazione : Form
    {
        public FormRegistrazione()
        {
            InitializeComponent();
        }

        private void FormRegistrazione_Load(object sender, EventArgs e)
        {

        }

        Albergo albergoGirasole = new Albergo();
        private void btnRegistrati_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente
                ( boxNome.Text,
                  boxCognome.Text,
                  boxCodiceFiscale.Text,
                  boxEmail.Text,
                  int.Parse(boxTelefono.Text)
                );

            albergoGirasole.AggiungiCliente(c);

            
            if (CheckRegistrazione(c))
            {
                FormMain main = new FormMain();
                main.ShowDialog();
            }
        }

        private void btnAccedi_Click(object sender, EventArgs e)
        {
            FormAccesso formAccesso = new FormAccesso();
            formAccesso.ShowDialog();   
        }

        public bool CheckRegistrazione(Cliente c)
        {
            bool available = true;
            foreach (string item in File.ReadLines(@"C:\Users\deben\OneDrive\Documenti\GitHub\SoftwarePrenotazioniCamere\listaClienti.txt"))
            {
                if (c.ToString() == item)
                {
                    available = false;
                }
            }

            if (available)
            {
                StreamWriter sw = File.AppendText(@"C:\Users\deben\OneDrive\Documenti\GitHub\SoftwarePrenotazioniCamere\listaClienti.txt");
                sw.WriteLine(c.ToString());
                sw.Close();
            }
            else
            {
                lblError.Text = "Stai provando a registrarti con un profilo già registrato";
                boxNome.Text = "";
                boxCognome.Text = "";
                boxCodiceFiscale.Text = "";
                boxEmail.Text = "";
                boxTelefono.Text = "";
            }
            
            return available;
        }
    }
}
