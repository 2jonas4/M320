using GeekJokes.Models;
using GeekJokes.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeekJokes.Tests
{
    [TestClass]
    public class JokeAnalyzerTests
    {
        [TestMethod]
        public void GetWordCount_ReturnsCorrectNumberOfWords()
        {
            // Arrange
            JokeAnalyzer analyzer = new JokeAnalyzer();
            Joke joke = new Joke { JokeText = "Hello World!" };

            // Act
            int wordCount = analyzer.GetWordCount(joke);

            // Assert
            Assert.AreEqual(2, wordCount);
        }

        [TestMethod]
        public void GetCharCount_WithAllCharacters_ReturnsTotalLength()
        {
            // Arrange
            JokeAnalyzer analyzer = new JokeAnalyzer();
            Joke joke = new Joke { JokeText = "Hello World!" };

            // Act
            int charCount = analyzer.GetCharCount(joke, includeSpecialChars: true, includeWhitespaces: true);

            // Assert
            Assert.AreEqual(12, charCount);
        }

        [TestMethod]
        public void GetCharCount_WithoutWhitespaces_ExcludesSpaces()
        {
            // Arrange
            JokeAnalyzer analyzer = new JokeAnalyzer();
            Joke joke = new Joke { JokeText = "Hello World!" };

            // Act
            int charCount = analyzer.GetCharCount(joke, includeSpecialChars: true, includeWhitespaces: false);

            // Assert
            Assert.AreEqual(11, charCount);
        }

        [TestMethod]
        public void GetCharCount_OnlyAlphanumeric_ExcludesSpacesAndSpecialChars()
        {
            // Arrange
            JokeAnalyzer analyzer = new JokeAnalyzer();
            Joke joke = new Joke { JokeText = "Hello World!" };

            // Act
            int charCount = analyzer.GetCharCount(joke, includeSpecialChars: false, includeWhitespaces: false);

            // Assert
            Assert.AreEqual(10, charCount);
        }
    }
}