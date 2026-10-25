using System;
using System.Collections.Generic;
using System.Text;

namespace uebung_fussballmannschaft
{
    internal class Spiel
    {
        public Fussballmannschaft Team1 { get; set; }

        public Fussballmannschaft Team2 { get; set; }

        public Resultat Spielen()
        {
            Resultat resultat = new Resultat();

            resultat.Team1Tore = Team1.Spielzug();
            resultat.Team2Tore = Team2.Spielzug();

            return resultat;
        }
    }
}