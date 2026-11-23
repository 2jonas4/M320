using System;

namespace GameLogger
{
    public class KonsolenAusgabe : IAusgabe
    {
        public void Schreiben(string meldung)
        {
            Console.WriteLine(meldung);
        }
    }
}