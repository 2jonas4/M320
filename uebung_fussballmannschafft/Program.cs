namespace uebung_fussballmannschaft
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fussballmannschaft fcb = new Fussballmannschaft();
            fcb.Name = "FC Basel";

            fcb.Torwart = new Torwart();
            fcb.Torwart.Name = "Yann";

            fcb.Feldspieler = new List<Feldspieler>()
            {
                new Feldspieler(){ Name = "Max" },
                new Feldspieler(){ Name = "Luca" }
            };

            Fussballmannschaft fcsg = new Fussballmannschaft();
            fcsg.Name = "FC St.Gallen";

            fcsg.Torwart = new Torwart();
            fcsg.Torwart.Name = "Peter";

            fcsg.Feldspieler = new List<Feldspieler>()
            {
                new Feldspieler(){ Name = "Tim" },
                new Feldspieler(){ Name = "Noah" }
            };

            Spiel spiel = new Spiel();

            spiel.Team1 = fcb;
            spiel.Team2 = fcsg;

            Resultat resultat = spiel.Spielen();

            Console.WriteLine();
            Console.WriteLine("RESULTAT");
            Console.WriteLine($"{fcb.Name}: {resultat.Team1Tore}");
            Console.WriteLine($"{fcsg.Name}: {resultat.Team2Tore}");
        }
    }
}