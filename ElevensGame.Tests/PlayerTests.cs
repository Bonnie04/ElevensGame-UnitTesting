using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElevensGame;

namespace ElevensGame.Tests
{
    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
        public void Constructor_ValidName_CreatesPlayerWithEmptyHand()
        {
            Player player = new Player("Test Player");
            
            Assert.AreEqual("Test Player", player.Name);
            Assert.AreEqual(0, player.GetHandSize());
            Assert.AreEqual(0, player.Score);
        }

        [TestMethod]
        public void AddCard_ValidCard_IncreasesHandSize()
        {
            Player player = new Player("Test Player");
            Card card = new Card("Ace", "Hearts");
            
            player.AddCard(card);
            
            Assert.AreEqual(1, player.GetHandSize());
            Assert.IsTrue(player.Hand.Contains(card));
        }

        [TestMethod]
        public void RemoveCard_ExistingCard_RemovesCardAndReturnsTrue()
        {
            Player player = new Player("Test Player");
            Card card = new Card("Ace", "Hearts");
            player.AddCard(card);
            
            bool result = player.RemoveCard(card);
            
            Assert.IsTrue(result);
            Assert.AreEqual(0, player.GetHandSize());
            Assert.IsFalse(player.Hand.Contains(card));
        }

        [TestMethod]
        public void ClearHand_HandWithCards_EmptiesHand()
        {
            Player player = new Player("Test Player");
            player.AddCard(new Card("Ace", "Hearts"));
            player.AddCard(new Card("King", "Spades"));
            
            player.ClearHand();
            
            Assert.AreEqual(0, player.GetHandSize());
        }
    }
}