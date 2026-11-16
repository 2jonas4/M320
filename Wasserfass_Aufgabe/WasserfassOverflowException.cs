using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace Wasserfass_Aufgabe
{
    public class WasserfassOverflowException : WasserfassException
    {
        public WasserfassOverflowException()
            : base("Das Wasserfass würde überlaufen.")
        {
        }
    }
}
