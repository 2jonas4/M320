using GeekJokes.Models;
using System.Threading.Tasks;

namespace GeekJokes.Services
{
    public interface IJokeProvider
    {
        Task<Joke> GetJoke(bool excludeChuckNorris = true);
    }
}