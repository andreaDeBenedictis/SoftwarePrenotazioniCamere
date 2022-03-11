using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClassiPrenotazioneCamere
{
    public class Camera
    {
        public int Numero { get; }
        public string Descrizione { get; }
        public bool Tipo { get; }
        public Camera(int n, bool t)
        {
            Numero = n;
            Tipo = t;
            if (Tipo) Descrizione = "Camera " + Numero +  ". Singola, 1 letto, 1 bagno";
            else Descrizione = "Camera " + Numero + ". Doppia, 2 letti, 1 bagno";
        }

        public string GetInfo()
        {
            return Descrizione;
        }
    }
}