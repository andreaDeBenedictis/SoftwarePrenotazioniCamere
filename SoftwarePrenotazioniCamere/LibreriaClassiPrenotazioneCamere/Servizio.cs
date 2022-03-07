using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClassiPrenotazioneCamere
{
    public class Servizio
    {
        public int prezzo { get; set; }
        public Servizio()
        {
            prezzo = CheckPrezzo();
        }
        public int CheckPrezzo()
        {
            return 0;
        }
    }
}
