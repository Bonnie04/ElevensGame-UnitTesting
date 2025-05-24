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
            Card card = new Card(Card.Suit.Hearts, Card.Rank.Ace);
            
            player.AddCard(card);
            
            Assert.AreEqual(1, player.GetHandSize());
            Assert.IsTrue(player.Hand.Contains(card));
        }

        [TestMethod]
        public void RemoveCard_ExistingCard_RemovesCardAndReturnsTrue()
        {
            Player player = new Player("Test Player");
            Card card = new Card(Card.Suit.Hearts, Card.Rank.Ace);
            player.AddCard(card);
            
            bool result = player.RemoveCard(card);
            
            Assert.IsTrue(result);
            Assert.AreEqual(0, player.GetHandSize());
            Assert.IsFalse(player.Hand.Contains(card));
        }

        [TestMethod]
        public void RemoveCard_NonExistingCard_ReturnsFalse()
        {
            Player player = new Player("Test Player");
            Card card1 = new Card(Card.Suit.Hearts, Card.Rank.Ace);
            Card card2 = new Card(Card.Suit.Spades, Card.Rank.King);
            player.AddCard(card1);
            
            bool result = player.RemoveCard(card2);
            
            Assert.IsFalse(result);
            Assert.AreEqual(1, player.GetHandSize());
        }

        [TestMethod]
        public void ClearHand_HandWithCards_EmptiesHand()
        {
            Player player = new Player("Test Player");
            player.AddCard(new Card(Card.Suit.Hearts, Card.Rank.Ace));
            player.AddCard(new Card(Card.Suit.Spades, Card.Rank.King));
            
            player.ClearHand();
            
            Assert.AreEqual(0, player.GetHandSize());
        }
    }
}