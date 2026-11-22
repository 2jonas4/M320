using GeekJokes.Models;
using GeekJokes.Services;
using System;
using System.Threading.Tasks;

namespace M320_GeekJokes
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            IJokeProvider jokeProvider = new JokeProvider();
            IJokeAnalyzer jokeAnalyzer = new JokeAnalyzer();
            JokeService jokeService = new JokeService(jokeProvider, jokeAnalyzer);

            bool printMoreJokes;

            Console.Clear();

            do
            {
                Joke joke = await jokeService.RetrieveAndAnalyzeJoke();
                Console.WriteLine(joke);

                Console.Write("\n=> Would you like to enjoy one more joke? [y/n] ");
                var key = Console.ReadKey();
                Console.WriteLine("\n");
                printMoreJokes = key.KeyChar.ToString().ToLower() != "n";
                if (printMoreJokes)
                {
                    Console.Clear();
                }
            } while (printMoreJokes);
        }
    }
}