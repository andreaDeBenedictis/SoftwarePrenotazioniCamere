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