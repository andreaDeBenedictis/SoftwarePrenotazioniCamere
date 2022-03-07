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
        public Camera(int n, string d, bool t)
        {
            Numero = n;
            Descrizione = d;
            Tipo = t;
        }
    }
}