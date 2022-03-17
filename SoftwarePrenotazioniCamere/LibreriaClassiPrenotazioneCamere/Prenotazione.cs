namespace LibreriaClassiPrenotazioneCamere
{
    public class Prenotazione
    {
        public Cliente Cliente { get; set; }
        public Camera Camera { get; set; }
        public DateTime DataInizio { get; set; }
        public DateTime DataFine { get; set; }


        public Prenotazione(Cliente c, Camera cam, DateTime dataInizio, DateTime dataFine)
        {
            Cliente = c;
            Camera = cam;
            this.DataInizio = dataInizio;
            this.DataFine = dataFine;
        }

        public override string ToString()
        {
            return Cliente.ToString() + " " + Camera.Numero + " " + "Data";
        }
    }
}
