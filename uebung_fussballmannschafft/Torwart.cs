using System;
using System.Collections.Generic;
using System.Text;

namespace uebung_fussballmannschaft
{
    internal class Torwart
    {
        public string Name { get; set; }

        public void SchussHalten()
        {
            Console.WriteLine($"{Name} hält den Schuss!");
        }

        public void Abstoss()
        {
            Console.WriteLine($"{Name} macht einen Abstoss!");
        }
    }
}