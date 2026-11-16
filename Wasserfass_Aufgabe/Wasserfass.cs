using System;
using System.Collections.Generic;
using System.Text;



using System;

namespace Wasserfass_Aufgabe
{
    public class Wasserfass
    {
        public int MinimalPegel { get; }
        public int MaximalPegel { get; }
        public int Füllstand { get; private set; }
        public int Kapazität { get; }

        public Wasserfass(int kapazitaet)
        {
            if (kapazitaet <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(kapazitaet), "Die Kapazität muss grösser als 0 sein.");
            }

            Kapazität = kapazitaet;
            MinimalPegel = 0;
            MaximalPegel = kapazitaet;
            Füllstand = 0;
        }

        public void Befüllen(int menge)
        {
            if (menge < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(menge), "Die Menge darf nicht negativ sein.");
            }

            if (Füllstand + menge > MaximalPegel)
            {
                throw new WasserfassOverflowException();
            }

            Füllstand += menge;
        }

        public void Entnehmen(int menge)
        {
            if (menge < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(menge), "Die Menge darf nicht negativ sein.");
            }

            if (Füllstand - menge < MinimalPegel)
            {
                throw new WasserfassUnderflowException();
            }

            Füllstand -= menge;
        }

        public void Entleeren()
        {
            Füllstand = 0;
        }
    }
}
