using System;

namespace GameLogger
{
    public class GrossbuchstabenAusgabe : IAusgabe
    {
        public void Schreiben(string meldung)
        {
            Console.WriteLine(meldung.ToUpper());
        }
    }
}