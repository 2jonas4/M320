namespace ExceptionHandling
{
    using System;

    namespace ExceptionHandling
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                int value;
                do
                {
                    Console.WriteLine("Geben Sie eine Zahl ein:");
                    string s = Console.ReadLine();

                    // Hier Converter0 bis Converter5 testen:
                    value = Converter0.ConvertToInt(s);

                    Console.WriteLine("Zahl ist {0}", value);
                } while (value != 0);
            }
        }
    }
}
