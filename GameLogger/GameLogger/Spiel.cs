namespace GameLogger
{
    public class Spiel
    {
        private readonly IAusgabe ausgabe;

        public Spiel(IAusgabe ausgabe)
        {
            this.ausgabe = ausgabe;
        }

        public void Starten()
        {
            ausgabe.Schreiben("Spiel gestartet!");
        }

        public void Beenden()
        {
            ausgabe.Schreiben("Spiel beendet!");
        }
    }
}