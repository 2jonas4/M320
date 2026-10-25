using System;
using System.Security.Cryptography;

namespace ClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rechteck r1 = new Rechteck();
            r1.Hoehe = 1;
            r1.Breite = 2;
            r1.Position = new Punkt() { X = 3, Y = 3 };
            r1.LinienFarbe = "grün";

            r1.Zeichne();
            r1.Verschiebe(2, 3);
            r1.Skaliere(0.5);
            r1.Zeichne();
            r1.flaeche = 7;

            Rechteck r1 = new Rechteck();
            r2.Hoehe = 1;
            r2.Breite = 2;
            r2.LinienFarbe = "blau";
            r2.Position = new Punkt() { X = 3, Y = 3 };
        }
 
    }

    public class Rechteck
    {
        // public int Id; // Klassenvariable oder Attribut
        public int Id { get; set; }
        public double Hoehe {  get; set; } // property 
        // public double Breite { get; } // ReadOnly-Property 
        public double Breite { get; set; } // ReadOnly-Property 

        public Punkt Position { get; set; }

        public string LinienFarbe { get; set; }

        private double flaeche;

        public void Verschiebe(double dx, double dy)
        {
            double newX = Position.X + dx;
            double newY = Position.Y + dy;

            Position = new Punkt() { X = newX, Y = newY };
        }

        public void Skaliere(double faktor)
        {
            Breite = Breite * faktor; 
            Hoehe = Hoehe * faktor;
        }

        public void Zeichne()
        {
            if (Position == null)
            {
                Console.WriteLine("Rechteck hat keine Position gesetzt.");
                return;
            }

            Console.WriteLine($"Rechteck Id={Id}, Hoehe={Hoehe}, Breite={Breite}, Position.X={Position.X}, Position.Y={Position.Y}, LinienFarbe={LinienFarbe}");
        }
    }
        
    public class Punkt
    {
        public double X { get; set; }
        public double Y { get; set; }
    }    
}

