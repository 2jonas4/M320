using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace ExceptionHandling
{
    public class Converter3
    {
        public static int ConvertToInt(string s)
        {
            int value;
            try
            {
                value = ConvertToIntFunc(s);
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

        private static int ConvertToIntFunc(string s)
        {
            if (s.StartsWith("-"))
            {
                throw new ArgumentException("keine Negativen Zahlen");
            }
            return Convert.ToInt32(s);
        }
    }
}
