using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClassiPrenotazioneCamere
{
    public class Prenotazione
    {
        public Cliente Cliente { get; set; }
        public Camera Camera { get; set; }

        public List<Servizio> Servizi;

        public Prenotazione(Cliente c, Camera cam)
        {
            Servizi = new List<Servizio>();
            Cliente = c;
            Camera = cam;
        }

        public override string ToString()
        {
            return Cliente.ToString() + " " +  Camera.Numero + " " + "Data";
        }
    }
}
