namespace Vererbung3_Hund
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

            Console.WriteLine($"Grösse Hund: {hund.Groesse}");
            hund.Bellen();

            Console.WriteLine($"Grösse Jagdhund: {jagdhund.Groesse}");
            Console.WriteLine($"Geschwindigkeit: {jagdhund.Geschwindigkeit}");

            jagdhund.Bellen();
            jagdhund.Fass("Kaninchen");
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

        public void Fass(string ziel)
        {
            Console.WriteLine($"Ich habe das {ziel} geschnappt.");
        }
    }
}