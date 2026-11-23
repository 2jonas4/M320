using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogger
{
    public interface IAusgabe
    {
        void Schreiben(string meldung);
    }
}
