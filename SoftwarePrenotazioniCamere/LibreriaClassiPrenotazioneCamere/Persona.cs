using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClassiPrenotazioneCamere
{
    public class Persona
    {
        public string Nome { get; }
        public string Cognome { get; }
        public string CodiceFiscale { get; }
        public string Email { get; }
        public int RecapitoTelefonico { get; }

        public Persona(string n, string c, string cf, string email, int tel)
        {
            Nome = n;
            Cognome = c;
            CodiceFiscale = cf;
            Email = email;
            RecapitoTelefonico = tel;
        }
    }

    public class Cliente : Persona
    {
        public string Città { get; }
        public string Provincia { get; }
        public Cliente(string n, string c, string cf, string email, int tel, string cit, string p) : base(n, c, cf, email, tel)
        {
            Città = cit;
            Provincia = p;
        }
    }
}
