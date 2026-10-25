using System;
using System.Collections.Generic;
using System.Text;

namespace uebung_fussballmannschaft
{
    internal class Feldspieler
    {
        public string Name { get; set; }

        public void AufsTorSchiessen()
        {
            Console.WriteLine($"{Name} schiesst aufs Tor!");
        }

        public void Graetschen()
        {
            Console.WriteLine($"{Name} macht eine Blutgrätsche!");
        }

        public void Dribbeln()
        {
            Console.WriteLine($"{Name} dribbelt den Gegner schwindlig!");
        }
    }
}