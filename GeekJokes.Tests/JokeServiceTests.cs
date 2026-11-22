using GeekJokes.Models;
using GeekJokes.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace GeekJokes.Tests
{
    [TestClass]
    public class JokeServiceTests
    {
        [TestMethod]
        public async Task RetrieveAndAnalyzeJoke_WithFakes_ReturnsExpectedJokeAndAnalytics()
        {
            // Arrange
            IJokeProvider fakeProvider = new FakeJokeProvider();
            IJokeAnalyzer fakeAnalyzer = new FakeJokeAnalyzer();
            JokeService jokeService = new JokeService(fakeProvider, fakeAnalyzer);

            // Act
            Joke result = await jokeService.RetrieveAndAnalyzeJoke();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("There are 10 types of people.", result.JokeText);
            Assert.IsNotNull(result.Analytics);
            Assert.AreEqual(6, result.Analytics.WordCount);
            Assert.AreEqual(29, result.Analytics.CharCount);
            Assert.AreEqual(5, result.Analytics.Funniness);
        }
    }
}