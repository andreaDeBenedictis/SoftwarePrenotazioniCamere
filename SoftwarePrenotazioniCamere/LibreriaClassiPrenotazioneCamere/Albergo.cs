namespace LibreriaClassiPrenotazioneCamere
{
    public class Albergo
    {

        public List<Prenotazione> Prenotazioni { get; }
        public List<Cliente> Clienti { get; }
        public List<Camera> Camere { get; }
        public List<Camera> Piano1 { get; }
        public List<Camera> Piano2 { get; }
        public List<Camera> Piano3 { get; }

        public Albergo()
        {
            Prenotazioni = new List<Prenotazione>();

            IstanziaListaPrenotazioni(Prenotazioni);

            Clienti = new List<Cliente>();

            IstanziaListaClienti(Clienti);

            Piano1 = new List<Camera>();
            Piano2 = new List<Camera>();
            Piano3 = new List<Camera>();

            RiempiListaCamerePiani(); // riempie le liste delle camere (piano 1, piano2 e piano 3) in base al piano

            Camere = new List<Camera>();

            RiempimentoListaCamere();
        }
        public void AggiungiPrenotazione(Prenotazione prenotazione)
        {
            Prenotazioni.Add(prenotazione);
        }
        public void AggiungiCliente(Cliente cliente)
        {
            Clienti.Add(cliente);
        }

        public void IstanziaListaClienti(List<Cliente> lista)
        {
            foreach (string line in File.ReadLines(GetPathClienti()))
            {
                string[] lines = line.Split(";");
                Cliente c = new Cliente(lines[0], lines[1], lines[2], lines[3], lines[4]);
                lista.Add(c);
            }
        }

        public void IstanziaListaPrenotazioni(List<Prenotazione> lista)
        {
            foreach (string line in File.ReadLines(GetPathPrenotazioni()))
            {
                bool tipo = true;
                string[] lines = line.Split(";");

                Cliente cliente = new Cliente(lines[0], lines[1], lines[2], lines[3], lines[4]);

                if (lines[6] == "True") tipo = true;
                else tipo = false;

                Camera camera = new Camera(int.Parse(lines[5]), tipo);

                DateTime inizio = new DateTime(int.Parse(lines[9]), int.Parse(lines[8]), int.Parse(lines[7]));

                DateTime fine = new DateTime(int.Parse(lines[12]), int.Parse(lines[11]), int.Parse(lines[10]));

                Prenotazione prenotazione = new Prenotazione(cliente, camera, inizio, fine);

                lista.Add(prenotazione);
            }
        }

        public void RiempiListaCamerePiani() // riempie le liste delle camere (piano 1, piano2 e piano 3) in base al piano
        {
            for (int i = 0; i < 11; i++)
            {
                if (i <= 5 && i != 0)
                {
                    Camera c1 = new Camera(100 + i, true);
                    Piano1.Add(c1);

                    Camera c2 = new Camera(200 + i, true);
                    Piano2.Add(c2);

                    Camera c3 = new Camera(300 + i, true);
                    Piano3.Add(c3);
                }
                else if (i > 5 && i != 0)
                {
                    Camera c1 = new Camera(100 + i, false);
                    Piano1.Add(c1);

                    Camera c2 = new Camera(200 + i, false);
                    Piano2.Add(c2);

                    Camera c3 = new Camera(300 + i, false);
                    Piano3.Add(c3);
                }
            }
        }
        public string GetPathClienti()
        {
            string pathDirectory = Directory.GetCurrentDirectory();
            string[] subPaths = pathDirectory.Split("\\");
            string path = "";

            for (int i = 0; i < subPaths.Length - 5; i++)
            {
                path += $"{subPaths[i]}\\";
            }

            return path + "listaClienti.txt";
        }

        public string GetPathPrenotazioni()
        {
            string pathDirectory = Directory.GetCurrentDirectory();
            string[] subPaths = pathDirectory.Split("\\");
            string path = "";

            for (int i = 0; i < subPaths.Length - 5; i++)
            {
                path += $"{subPaths[i]}\\";
            }

            return path + "listaPrenotazioni.txt";
        }

        public void ControlloDateDisponibili()
        {

        }
        private void RiempimentoListaCamere()
        {
            for (int i = 0; i < 11; i++)
            {
                if (i <= 5 && i != 0)
                {
                    Camera c1 = new Camera(100 + i, true);
                    Camere.Add(c1);

                    Camera c2 = new Camera(200 + i, true);
                    Camere.Add(c2);

                    Camera c3 = new Camera(300 + i, true);
                    Camere.Add(c3);
                }
                else if (i > 5 && i != 0)
                {
                    Camera c1 = new Camera(100 + i, false);
                    Camere.Add(c1);

                    Camera c2 = new Camera(200 + i, false);
                    Camere.Add(c2);

                    Camera c3 = new Camera(300 + i, false);
                    Camere.Add(c3);
                }
            }
        }
    }
}