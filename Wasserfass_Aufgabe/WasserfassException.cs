using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace Wasserfass_Aufgabe
{
    public class WasserfassException : Exception
    {
        public WasserfassException(string message)
            : base(message)
        {
        }
    }
}
