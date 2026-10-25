namespace Vererbung5_Warenwirtschaft
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produkt produkt = new Produkt();
            produkt.Artikelnummer = 1001;
            produkt.Name = "Standardprodukt";
            produkt.NettoPreis = 9.90;

            MusikCD cd = new MusikCD();
            cd.Artikelnummer = 2001;
            cd.Name = "Best Of";
            cd.NettoPreis = 19.90;
            cd.Laufzeit = 60;
            cd.Interpret = "Michael Jackson";

            Kinderfahrrad fahrrad = new Kinderfahrrad();
            fahrrad.Artikelnummer = 3001;
            fahrrad.Name = "Kinderbike";
            fahrrad.NettoPreis = 249.90;

            Console.WriteLine("PRODUKT");
            Console.WriteLine($"Artikelnummer: {produkt.Artikelnummer}");
            Console.WriteLine($"Name: {produkt.Name}");
            Console.WriteLine($"Preis: {produkt.NettoPreis}");

            Console.WriteLine();

            Console.WriteLine("MUSIK-CD");
            Console.WriteLine($"Artikelnummer: {cd.Artikelnummer}");
            Console.WriteLine($"Name: {cd.Name}");
            Console.WriteLine($"Preis: {cd.NettoPreis}");
            Console.WriteLine($"Laufzeit: {cd.Laufzeit}");
            Console.WriteLine($"Interpret: {cd.Interpret}");

            Console.WriteLine();

            Console.WriteLine("KINDERFAHRRAD");
            Console.WriteLine($"Artikelnummer: {fahrrad.Artikelnummer}");
            Console.WriteLine($"Name: {fahrrad.Name}");
            Console.WriteLine($"Preis: {fahrrad.NettoPreis}");

            fahrrad.KlingelAuswaehlen("Rot");
        }
    }

    public class Produkt
    {
        public int Artikelnummer { get; set; }
        public string Name { get; set; }
        public double NettoPreis { get; set; }
    }

    public class MusikCD : Produkt
    {
        public int Laufzeit { get; set; }
        public string Interpret { get; set; }
    }

    public class Kinderfahrrad : Produkt
    {
        public void KlingelAuswaehlen(string klingelFarbe)
        {
            Console.WriteLine($"Klingelfarbe gewählt: {klingelFarbe}");
        }
    }
}
