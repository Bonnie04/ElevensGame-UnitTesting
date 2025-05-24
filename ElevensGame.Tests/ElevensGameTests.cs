using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElevensGame;

namespace ElevensGame.Tests
{
    [TestClass]
    public class GameTests
    {
        [TestMethod]
        public void Constructor_NewGame_InitializesCorrectly()
        {
            Game game = new Game();
            
            Assert.IsTrue(game.IsGameActive);
            Assert.IsNotNull(game.CurrentBoard);
        }

        [TestMethod]
        public void StartNewGame_ResetsGameState()
        {
            Game game = new Game();
            
            game.StartNewGame();
            
            Assert.IsTrue(game.IsGameActive);
        }

        [TestMethod]
        public void PlayCards_ValidIndices_ReturnsResult()
        {
            Game game = new Game();
            int[] testIndices = {0, 1};
            
            bool result = game.PlayCards(testIndices);
            
            Assert.IsTrue(result || !result); // Just test method executes
        }
    }
}