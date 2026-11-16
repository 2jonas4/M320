using System;


namespace Wasserfass_Aufgabe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wasserfass fass = new Wasserfass(100);

            try
            {
                fass.Befüllen(50);
                Console.WriteLine("Befüllen erfolgreich");
                Console.WriteLine("Füllstand: " + fass.Füllstand);

                // Löst WasserfassOverflowException aus
                fass.Befüllen(60);
            }
            catch (WasserfassOverflowException ex)
            {
                Console.WriteLine("Fehler: " + ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Ungültige Eingabe: " + ex.Message);
            }

            try
            {
                // Löst WasserfassUnderflowException aus
                fass.Entnehmen(200);
            }
            catch (WasserfassUnderflowException ex)
            {
                Console.WriteLine("Fehler: " + ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Ungültige Eingabe: " + ex.Message);
            }

            Console.WriteLine("Füllstand am Ende: " + fass.Füllstand);
            Console.ReadKey();
        }
    }
}