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

        Albergo albergoGirasole = new Albergo();
        private void btnRegistrati_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente
                ( boxNome.Text,
                  boxCognome.Text,
                  boxPassword.Text,
                  boxEmail.Text,
                  int.Parse(boxTelefono.Text)
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
            foreach (string item in File.ReadLines(/*@"C:\Users\deben\OneDrive\Documenti\GitHub\SoftwarePrenotazioniCamere\listaClienti.txt"*/@"C:\Users\Acer\OneDrive\Documenti\GitHub\SoftwarePrenotazioniCamere\listaClienti.txt"))
            {
                if (c.ToString() == item)
                {
                    available = false;
                }
            }

            if (available)
            {
                StreamWriter sw = File.AppendText(/*@"C:\Users\deben\OneDrive\Documenti\GitHub\SoftwarePrenotazioniCamere\listaClienti.txt"*/@"C:\Users\Acer\OneDrive\Documenti\GitHub\SoftwarePrenotazioniCamere\listaClienti.txt");
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
