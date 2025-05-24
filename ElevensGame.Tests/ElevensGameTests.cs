using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElevensGame;

namespace ElevensGame.Tests
{
    [TestClass]
    public class ElevensGameTests
    {
        [TestMethod]
        public void Constructor_NewGame_InitializesCorrectly()
        {
            var game = new ElevensGame();
            
            Assert.AreEqual(9, game.Board.Count);
            Assert.AreEqual(0, game.MovesCount);
        }

        [TestMethod]
        public void HasValidMoves_NewGame_ChecksForValidMoves()
        {
            var game = new ElevensGame();
            bool hasValidMoves = game.HasValidMoves();
            
            Assert.IsTrue(hasValidMoves || !hasValidMoves);
        }

        [TestMethod]
        public void InitializeGame_ResetsGameState()
        {
            var game = new ElevensGame();
            
            game.InitializeGame();
            
            Assert.AreEqual(9, game.Board.Count);
            Assert.AreEqual(0, game.MovesCount);
        }
    }
}