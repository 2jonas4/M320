using GeekJokes.Models;
using GeekJokes.Services;
using System.Threading.Tasks;

namespace GeekJokes.Tests
{
    public class FakeJokeProvider : IJokeProvider
    {
        public Task<Joke> GetJoke(bool excludeChuckNorris = true)
        {
            Joke staticJoke = new Joke
            {
                JokeText = "There are 10 types of people."
            };
            return Task.FromResult(staticJoke);
        }
    }
}