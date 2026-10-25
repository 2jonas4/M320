namespace Vererbung4_Hund
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hund hund = new Hund();
            hund.Groesse = 50;

            Jagdhund jagdhund = new Jagdhund();
            jagdhund.Groesse = 70;
            jagdhund.Geschwindigkeit = 40;

            EntfesselterJagdhund entfesselter = new EntfesselterJagdhund();
            entfesselter.Groesse = 80;
            entfesselter.Geschwindigkeit = 60;
            entfesselter.Blutdurst = "Hoch";

            Console.WriteLine("HUND");
            Console.WriteLine($"Grösse: {hund.Groesse}");
            hund.Bellen();

            Console.WriteLine();

            Console.WriteLine("JAGDHUND");
            Console.WriteLine($"Grösse: {jagdhund.Groesse}");
            Console.WriteLine($"Geschwindigkeit: {jagdhund.Geschwindigkeit}");
            jagdhund.Bellen();
            jagdhund.Fass("Kaninchen");

            Console.WriteLine();

            Console.WriteLine("ENTFESSELTER JAGDHUND");
            Console.WriteLine($"Grösse: {entfesselter.Groesse}");
            Console.WriteLine($"Geschwindigkeit: {entfesselter.Geschwindigkeit}");
            Console.WriteLine($"Blutdurst: {entfesselter.Blutdurst}");

            entfesselter.Bellen();
            entfesselter.Fass("Reh");
            entfesselter.Zerfetze(10);
        }
    }

    public class Hund
    {
        public int Groesse { get; set; }

        public void Bellen()
        {
            Console.WriteLine("Wuff Wuff");
        }
    }

    public class Jagdhund : Hund
    {
        public int Geschwindigkeit { get; set; }

        public void Fass(string nameDesTiers)
        {
            Console.WriteLine($"Ich habe das {nameDesTiers} geschnappt.");
        }
    }

    public class EntfesselterJagdhund : Jagdhund
    {
        public string Blutdurst { get; set; }

        public void Fass(string nameDesTiers)
        {
            Console.WriteLine($"Ich habe das arme {nameDesTiers} erwischt!");
        }

        public void Zerfetze(int zeitdauer)
        {
            Console.WriteLine($"Ich zerfetze alles während {zeitdauer} Minuten!");
        }
    }
}