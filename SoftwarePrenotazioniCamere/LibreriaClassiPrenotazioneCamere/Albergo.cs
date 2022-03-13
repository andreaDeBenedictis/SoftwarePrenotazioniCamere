using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaClassiPrenotazioneCamere
{
    public class Albergo
    {

        public List<Prenotazione> Prenotazioni { get; }

        public List<Cliente> Clienti { get; }

        public List<Camera> Piano1 { get; }
        public List<Camera> Piano2 { get; }
        public List<Camera> Piano3 { get; }

        public Albergo()
        {
            Prenotazioni = new List<Prenotazione>();
            Clienti = new List<Cliente>();
            IstanziaListaClienti(Clienti);
            Piano1 = new List<Camera>();
            Piano2 = new List<Camera>();
            Piano3 = new List<Camera>();
            RiempiListaCamere();
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
            foreach (string line in File.ReadLines(@"C:\Users\deben\OneDrive\Documenti\GitHub\SoftwarePrenotazioniCamere\listaClienti.txt"))
            {
                string[] lines = line.Split(";");
                Cliente c = new Cliente(lines[0], lines[1], lines[2], lines[3], int.Parse(lines[4]));
                lista.Add(c);
            }
        }

        public void RiempiListaCamere()
        {
            for (int i = 0; i < 11; i++)
            {
                
                if (i <= 5 && i != 0)
                {
                    Camera c1 = new Camera(100 + i, true);
                    Piano1.Add(c1);

                    Camera c2 = new Camera(200 + i, true);
                    Piano2.Add(c2);

                    Camera c3 = new Camera(300 + i, true);
                    Piano3.Add(c3);
                }
                else if (i > 5 && i != 0)
                {
                    Camera c1 = new Camera(100 + i, false);
                    Piano1.Add(c1);

                    Camera c2 = new Camera(200 + i, false);
                    Piano2.Add(c2);

                    Camera c3 = new Camera(300 + i, false);
                    Piano3.Add(c3);
                }
            }
            
        }


    }
}