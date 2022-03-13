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
        public int Piano { get; }
        public string Descrizione { get; }
        public bool Tipo { get; }
        public Camera(int n, bool t)
        {
            Numero = n;
            Tipo = t;

            if (Tipo) Descrizione = "Camera " + Numero +  ". Singola, 1 letto, 1 bagno";
            else Descrizione = "Camera " + Numero + ". Doppia, 2 letti, 1 bagno";

            Piano = 0;
            if (Numero >= 100 && Numero < 200) Piano = 1;
            if (Numero >= 200 && Numero < 300) Piano = 2;
            if (Numero >= 300) Piano = 3;
        }

        public override string ToString()
        {
            return Descrizione;
        }


    }
}