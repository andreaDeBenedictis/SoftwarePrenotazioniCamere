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

        public void AggiungiCamera(Camera camera)
        {
            Camere.Add(camera);
        }
    }
}