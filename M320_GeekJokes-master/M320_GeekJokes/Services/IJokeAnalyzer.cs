using GeekJokes.Models;

namespace GeekJokes.Services
{
    public interface IJokeAnalyzer
    {
        int GetWordCount(Joke joke);
        int GetCharCount(Joke joke, bool includeSpecialChars = true, bool includeWhitespaces = true);
        int GetFunniness(Joke joke);
    }
}