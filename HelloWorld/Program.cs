using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 5;
            PrintNumber(a);

            int res = Add(5, 7);
            Console.WriteLine($"Main: {res}, a={a}");

            PrintMessage("hello");
        }

        static void PrintMessage(string s)
        {
            s = s + "abc";
            Console.WriteLine($"Message: {s}");
        }

        static int Add(int a, int b)
        {
            int c = a + b;
            return c;
        }

        static void PrintNumber(int a)
        {
            Console.WriteLine($"Zahl: {a}");
        }
    }
}
