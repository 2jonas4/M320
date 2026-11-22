using GeekJokes.Models;
using System.Threading.Tasks;

namespace GeekJokes.Services
{
    public class JokeService
    {
        private readonly IJokeProvider _jokeProvider;
        private readonly IJokeAnalyzer _jokeAnalyzer;

        public JokeService(IJokeProvider jokeProvider, IJokeAnalyzer jokeAnalyzer)
        {
            _jokeProvider = jokeProvider;
            _jokeAnalyzer = jokeAnalyzer;
        }

        public async Task<Joke> RetrieveAndAnalyzeJoke(bool includeSpecialChars = true, bool includeWhitespaces = true)
        {
            // Retrieve joke
            Joke joke = await _jokeProvider.GetJoke();

            // Analyze Joke
            int wordCount = _jokeAnalyzer.GetWordCount(joke);
            int charCount = _jokeAnalyzer.GetCharCount(joke, includeSpecialChars, includeWhitespaces);
            int funnyness = _jokeAnalyzer.GetFunniness(joke);
            JokeAnalytics analytics = new JokeAnalytics(wordCount, charCount, funnyness);
            joke.Analytics = analytics;

            return joke;
        }
    }
}