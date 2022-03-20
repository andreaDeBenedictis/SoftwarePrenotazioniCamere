namespace LibreriaClassiPrenotazioneCamere
{
    public class Camera
    {
        public int Numero { get; }
        public int Piano { get; }
        public string Descrizione { get; set;}
        public bool Tipo { get; } // se è true la camera è singola se è false la camera è doppia
        public int Prezzo { get; set; }
        public bool Disponibilità { get; set; } // se è false la camera è prenotata, se è true la camera è disponibile
        public List<Servizio> Servizi { get; }
        public Camera(int n, bool t)
        {
            Disponibilità = true;

            Numero = n;

            Tipo = t;

            Descrizione = "";
            SetDati();

            Piano = 0;
            if (Numero >= 100 && Numero < 200) Piano = 1;
            if (Numero >= 200 && Numero < 300) Piano = 2;
            if (Numero >= 300) Piano = 3;

            Servizi = new List<Servizio>();
            RiempiListaServizi(); // riempie la lista dei servizi con tutti i servizi
        }

        public override string ToString()
        {
            if (Disponibilità)
            {
                if (Tipo)
                {
                    return "Camera " + Numero + " - Singola - Disponibile";
                }
                else
                {
                    return "Camera " + Numero + " - Doppia - Disponibile";
                }
            }
            else
            {
                if (Tipo)
                {
                    return "Camera " + Numero + " - Singola - Prenotata";
                }
                else
                {
                    return "Camera " + Numero + " - Doppia - Prenotata";
                }
            }
        }

        public void RiempiListaServizi()
        {
            Servizi.Add(new Culla());
            Servizi.Add(new MiniBar());
            Servizi.Add(new Internet());
            Servizi.Add(new ColazioneInCamera());
        }

        public void SetDati()
        {
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
        }

        public void ResettaCamera() //resetta il prezzo della camera e resetta i servizi
        {
            if (Tipo == true)
            {
                Prezzo = 50;
            }
            else
            {
                Prezzo = 80;
            }
            foreach(Servizio s in Servizi)
            {
                s.Attivazione = false;
            }
        }
    }
}