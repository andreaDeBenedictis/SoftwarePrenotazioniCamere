using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaClassiPrenotazioneCamere
{
    public class Albergo
    {

        public List<Prenotazione> Prenotazioni { get; }
        public List<Cliente> Clienti { get; }
        public List<Camera> Camere { get; }

        public Albergo()
        {
            Prenotazioni = new List<Prenotazione>();
            Clienti = new List<Cliente>();
            IstanziaListaClienti(Clienti);
            Camere = new List<Camera>();
        }
        public void AggiungiPrenotazione(Prenotazione prenotazione)
        {
            Prenotazioni.Add(prenotazione);
        }
        public void AggiungiCliente(Cliente cliente)
        {
            Clienti.Add(cliente);
        }

        public void IstanziaListaClienti(List<Cliente> lista)
        {
            foreach (string line in File.ReadLines(/*@"C:\Users\deben\OneDrive\Documenti\GitHub\SoftwarePrenotazioniCamere\listaClienti.txt"*/@"C:\Users\Acer\OneDrive\Documenti\GitHub\SoftwarePrenotazioniCamere\listaClienti.txt"))
            {
                string[] lines = line.Split(";");
                Cliente c = new Cliente(lines[0], lines[1], lines[2], lines[3], int.Parse(lines[4]));
                lista.Add(c);
            }
        }

        public List<Camera> RiempiListaCamere() //Riempimento lista camere
        {
            List<Camera> camere = new List<Camera>();

            int k = 0;
            for (int i = 0; i < 30; i++)
            {
                if (i <= 9) k = 100;
                if (i > 9 && i <= 19) k = 200;
                if (i > 19) k = 300;

                if (i%2==0)
                {                   
                    Camera c1 = new Camera(k + i, true);
                    camere.Add(c1);
                }
                else
                {
                    Camera c2 = new Camera(k + i, false);
                    camere.Add(c2);
                }  
            }
            return camere;
        }
    }
}