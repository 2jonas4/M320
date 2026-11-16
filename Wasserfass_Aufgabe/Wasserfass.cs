using System;
using System.Collections.Generic;
using System.Text;



namespace Wasserfass_Aufgabe
{
    public class Wasserfass
    {
        public int MinimalPegel { get; }
        public int MaximalPegel { get; }
        public int Füllstand { get; private set; }
        public int Kapazität { get; }

        public Wasserfass(int kapazität)
        {
            Kapazität = kapazität;
            MinimalPegel = 0;
            MaximalPegel = kapazität;
            Füllstand = 0;
        }

        public Fehlercode Befüllen(int menge)
        {
            if (menge < 0)
            {
                return Fehlercode.NegativeMenge;
            }

            if (Füllstand + menge > MaximalPegel)
            {
                return Fehlercode.Ueberlauf;
            }

            Füllstand += menge;
            return Fehlercode.Erfolg;
        }

        public Fehlercode Entnehmen(int menge)
        {
            if (menge < 0)
            {
                return Fehlercode.NegativeMenge;
            }

            if (Füllstand - menge < MinimalPegel)
            {
                return Fehlercode.ZuWenigWasser;
            }

            Füllstand -= menge;
            return Fehlercode.Erfolg;
        }

        public Fehlercode Entleeren()
        {
            Füllstand = 0;
            return Fehlercode.Erfolg;
        }
    }
}
