namespace LibreriaClassiPrenotazioneCamere
{
    public class Persona
    {
        public string Nome { get; }
        public string Cognome { get; }
        public string Password { get; }
        public string Email { get; }
        public string RecapitoTelefonico { get; }

        public Persona(string n, string c, string p, string email, string tel)
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
        public Cliente(string n, string c, string p, string email, string tel) : base(n, c, p, email, tel)
        {

        }

        public override string ToString()
        {
            return Nome + ";" + Cognome + ";" + Password + ";" + Email + ";" + RecapitoTelefonico + ";";
        }
    }
}
