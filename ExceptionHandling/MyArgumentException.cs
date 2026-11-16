using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace ExceptionHandling
{
    public class MyArgumentException : System.ApplicationException
    {
        public MyArgumentException() : base()
        {
        }

        public MyArgumentException(string message) : base(message)
        {
        }
    }
}
