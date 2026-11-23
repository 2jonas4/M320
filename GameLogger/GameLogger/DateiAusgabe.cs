using System;
using System.IO;

namespace GameLogger
{
    public class DateiAusgabe : IAusgabe
    {
        public void Schreiben(string meldung)
        {
            File.AppendAllText("spiel.log", meldung + Environment.NewLine);
        }
    }
}