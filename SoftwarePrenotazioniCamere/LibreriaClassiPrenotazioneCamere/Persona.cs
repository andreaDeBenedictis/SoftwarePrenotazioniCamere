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
        public string Password { get; }
        public string Email { get; }
        public int RecapitoTelefonico { get; }

        public Persona(string n, string c, string p, string email, int tel)
        {
            Nome = n;
            Cognome = c;
            Password = p;
            Email = email;
            RecapitoTelefonico = tel;
        }
    }

    public class Cliente : Persona
    {
        public Cliente(string n, string c, string p, string email, int tel) : base(n, c, p, email, tel)
        {

        }

        public override string ToString()
        {
            return Nome + ";" + Cognome + ";" + Password + ";" + Email + ";" + RecapitoTelefonico + ";";
        }
    }
}
