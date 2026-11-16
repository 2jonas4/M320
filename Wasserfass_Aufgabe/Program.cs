using System;

namespace Wasserfass_Aufgabe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wasserfass fass = new Wasserfass(100);

            Fehlercode code = fass.Befüllen(50);

            if (code == Fehlercode.Erfolg)
            {
                Console.WriteLine("Befüllen erfolgreich");
            }
            else if (code == Fehlercode.NegativeMenge)
            {
                Console.WriteLine("Fehler: Negative Menge");
            }
            else if (code == Fehlercode.Ueberlauf)
            {
                Console.WriteLine("Fehler: Fass würde überlaufen");
            }

            Console.WriteLine("Füllstand: " + fass.Füllstand);

            code = fass.Befüllen(60);

            if (code == Fehlercode.Ueberlauf)
            {
                Console.WriteLine("Fehler: Fass würde überlaufen");
            }

            code = fass.Entnehmen(200);

            if (code == Fehlercode.ZuWenigWasser)
            {
                Console.WriteLine("Fehler: Zu wenig Wasser vorhanden");
            }

            Console.WriteLine("Füllstand am Ende: " + fass.Füllstand);

            Console.ReadKey();
        }
    }
}
