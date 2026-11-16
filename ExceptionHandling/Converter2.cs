using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace ExceptionHandling
{
    public class Converter2
    {
        public static int ConvertToInt(string s)
        {
            int value;
            try
            {
                value = Convert.ToInt32(s);
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Ausnahme ist aufgetreten: {0}", e.Message);
                value = -1;
            }
            finally
            {
                Console.WriteLine("Diese wird immer ausgeführt");
            }
            return value;
        }
    }
}
