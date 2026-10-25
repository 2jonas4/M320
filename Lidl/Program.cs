using System;
using System.Collections.Generic;

namespace Lidl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person1 = new Person();
            //person1.Name = "Müller";
            //person1.Vorname = "Max";

            Kunde kunde1 = new Kunde();
            kunde1.Name = "Walter";
            kunde1.Vorname = "Larissa";
            kunde1.Umsatz = 325.60;

            Lagerist lagerist1 = new Lagerist();
            lagerist1.Name = "Hutter";
            lagerist1.Vorname = "Peter";
            lagerist1.Groesse = 187;

            ChefLagerist chef1 = new ChefLagerist();
            chef1.Name = "Moser";
            chef1.Vorname = "Daniel";

            Kleinkind kind1 = new Kleinkind();
            kind1.Name = "Müller";
            kind1.Vorname = "Tim";

            List<Person> personen = new List<Person>();

            personen.Add(kunde1);
            personen.Add(lagerist1);
            personen.Add(chef1);
            personen.Add(kind1);

            foreach (Person p in personen)
            {
                p.Esse();
                p.Trage();
            }
        }
    }

    public abstract class Person
    {
        public string Name { get; set; }
        public string Vorname { get; set; }
        public void Esse()
        {
            Console.WriteLine($"{Vorname} {Name} isst.");
        }
        public abstract void Trage();

    }

    public class Kunde : Person
    {
        public double Umsatz { get; set; }
        public void Kaufen()
        {
            Console.WriteLine($"{Vorname} {Name} kauft ein.");
        }
        public override void Trage()
        {
            Console.WriteLine($"{Vorname} {Name} trägt Waren.");
        }
    }
    public class Lagerist : Person
    {
        public int Groesse { get; set; }
        public void LagereEin()
        {
            Console.WriteLine($"{Vorname} {Name} lagert ein.");
        }
        public void Lagern()
        {
            Console.WriteLine($"{Vorname} {Name} lagert Waren.");
        }
        public override void Trage()
        {
            Console.WriteLine($"{Vorname} {Name} trägt Waren.");
        }
    }
    public class ChefLagerist : Lagerist
    {
        public void LagereAus()
        {
            Console.WriteLine($"{Vorname} {Name} lagert Material aus.");
        }
    }
    public class Kleinkind : Person
    {
        public override void Trage()
        {
            Console.WriteLine($"{Vorname} {Name} trägt ein Spielzeug.");
        }
    }
}
