using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace ExceptionHandling
{
    internal class Converter5
    {
        public static int ConvertToInt(string s)
        {
            int value;
            try
            {
                if (s.Contains("x"))
                {
                    throw new System.ArgumentException("Bitte keine x in Eingabe");
                }
                value = ConvertToIntFunc(s);
            }
            catch (MyArgumentException e)
            {
                Console.WriteLine("MyArgumentException ist aufgetreten: {0}", e.Message);
                value = -2;
            }
            catch (System.ArgumentException e)
            {
                Console.WriteLine("ArgumentException ist aufgetreten: {0}", e.Message);
                value = -2;
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Exception ist aufgetreten: {0}", e.Message);
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
                throw new MyArgumentException("keine Negativen Zahlen");
            }
            return Convert.ToInt32(s);
        }
    }
}
