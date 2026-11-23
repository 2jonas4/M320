using System;

namespace GameLogger
{
    public class ZeitstempelAusgabe : IAusgabe
    {
        public void Schreiben(string meldung)
        {
            string zeitstempel = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
            Console.WriteLine($"{zeitstempel} - {meldung}");
        }
    }
}