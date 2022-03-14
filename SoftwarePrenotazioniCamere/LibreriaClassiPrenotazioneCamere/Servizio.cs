using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClassiPrenotazioneCamere
{
    public class Servizio
    {
        public bool Attivazione { get; set; }
        public string NomeServizio { get; protected set; }
        public int Prezzo { get; protected set; }
        public Servizio()
        {
            NomeServizio = "";
            Prezzo = 0;
        }
        public override string ToString()
        {
            return NomeServizio + ": " + Prezzo + "€";
        }
    }
    public class ColazioneInCamera : Servizio
    {
        public ColazioneInCamera() : base()
        {
            NomeServizio = "Colazione in camera";
            Prezzo = 15;
        }
    }
    public class MiniBar : Servizio
    {
        public MiniBar() : base()
        {
            NomeServizio = "Mini bar";
            Prezzo = 15;
        }
    }
    public class Internet : Servizio
    {
        public Internet() : base()
        {
            NomeServizio = "Internet";
            Prezzo = 15;
        }
    }
    public class Culla : Servizio
    {
        public Culla() : base()
        {
            NomeServizio = "Culla";
            Prezzo = 15;
        }
    }

}

