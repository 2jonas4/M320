using GeekJokes.Models;
using GeekJokes.Services;

namespace GeekJokes.Tests
{
    public class FakeJokeAnalyzer : IJokeAnalyzer
    {
        public int GetWordCount(Joke joke)
        {
            return 6;
        }

        public int GetCharCount(Joke joke, bool includeSpecialChars = true, bool includeWhitespaces = true)
        {
            return 29;
        }

        public int GetFunniness(Joke joke)
        {
            return 5;
        }
    }
}