using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace Wasserfass_Aufgabe
{
    public class WasserfassUnderflowException : WasserfassException
    {
        public WasserfassUnderflowException()
            : base("Zu wenig Wasser im Fass vorhanden.")
        {
        }
    }
}
