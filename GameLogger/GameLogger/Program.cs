namespace GameLogger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Gewünschte Ausgabeart aktivieren (die anderen auskommentiert lassen):
            // IAusgabe ausgabe = new KonsolenAusgabe();
            // IAusgabe ausgabe = new DateiAusgabe();
            // IAusgabe ausgabe = new ZeitstempelAusgabe();
            IAusgabe ausgabe = new GrossbuchstabenAusgabe();

            Spiel spiel = new Spiel(ausgabe);
            spiel.Starten();
            spiel.Beenden();
        }
    }
}