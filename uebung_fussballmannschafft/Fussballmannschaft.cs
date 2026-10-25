using System;
using System.Collections.Generic;
using System.Text;

namespace uebung_fussballmannschaft
{
    internal class Fussballmannschaft
    {
        public string Name { get; set; }

        public Torwart Torwart { get; set; }

        public List<Feldspieler> Feldspieler { get; set; }

        public int Spielzug()
        {
            foreach (Feldspieler spieler in Feldspieler)
            {
                spieler.Dribbeln();
                spieler.Graetschen();
                spieler.AufsTorSchiessen();
            }

            Torwart.SchussHalten();
            Torwart.Abstoss();

            return 1;
        }
    }
}
