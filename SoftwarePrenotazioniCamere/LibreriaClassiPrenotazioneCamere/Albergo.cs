using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaClassiPrenotazioneCamere
{
    public class Albergo
    {

        public List<Prenotazione> Prenotazioni { get; }

        public List<Cliente> Clienti { get; }

        public Albergo()
        {
            Prenotazioni = new List<Prenotazione>();
            Clienti = new List<Cliente>();
        }
        public void AggiungiPrenotazione(Prenotazione prenotazione)
        {
            Prenotazioni.Add(prenotazione);
        }
        public void AggiungiCliente(Cliente cliente)
        {
            Clienti.Add(cliente);
        }
    }
}