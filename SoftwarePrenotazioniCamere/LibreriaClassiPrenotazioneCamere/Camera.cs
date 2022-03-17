namespace LibreriaClassiPrenotazioneCamere
{
    public class Camera
    {
        public int Numero { get; }
        public int Piano { get; }
        public string Descrizione { get; }
        public bool Tipo { get; }
        public int Prezzo { get; set; }
        public bool Disponibilità { get; set; }
        public List<Servizio> Servizi { get; }
        public Camera(int n, bool t)
        {
            Numero = n;
            Tipo = t;

            if (Tipo)
            {
                Descrizione = "Le nostre camere singole dispongono di un solo letto singolo e di un bagno." +
                    "possiedono tutti i servizi principali come la presenza di un tv e del wi-fi gratuito.";

                Prezzo = 50;
            }
            else
            {
                Descrizione = "Le nostre camere doppie dispongono " +
                    "di due letti singoli o di un letto matrimoniale. " +
                    "Possiedono tutti i confort e i servizi necessari " +
                    "affinché possiate godervi al massimo il vostro soggiorno";

                Prezzo = 80;
            }


            Piano = 0;
            if (Numero >= 100 && Numero < 200) Piano = 1;
            if (Numero >= 200 && Numero < 300) Piano = 2;
            if (Numero >= 300) Piano = 3;

            Servizi = new List<Servizio>();
            RiempiListaServizi();
        }

        public override string ToString()
        {
            if (Tipo)
            {
                return "Camera " + Numero + ". Singola, 1 letto, 1 bagno";
            }
            else
            {
                return "Camera " + Numero + ". Doppia, 2 letti, 1 bagno";
            }
        }

        public void RiempiListaServizi()
        {
            Servizi.Add(new Culla());
            Servizi.Add(new MiniBar());
            Servizi.Add(new Internet());
            Servizi.Add(new ColazioneInCamera());
        }

        public void PrezzoBase()
        {
            if (Tipo == true)
            {
                Prezzo = 50;
            }
            else
            {
                Prezzo = 80;
            }
        }
    }
}