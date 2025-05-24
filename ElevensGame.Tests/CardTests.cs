using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElevensGame;

namespace ElevensGame.Tests
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void Constructor_ValidSuitAndRank_CreatesCard()
        {
            Card card = new Card(Card.Suit.Hearts, Card.Rank.Ace);
            
            Assert.AreEqual(Card.Suit.Hearts, card.CardSuit);
            Assert.AreEqual(Card.Rank.Ace, card.CardRank);
        }

        [TestMethod]
        public void GetValue_AceCard_ReturnsOne()
        {
            Card card = new Card(Card.Suit.Spades, Card.Rank.Ace);
            int value = card.GetValue();
            
            Assert.AreEqual(1, value);
        }

        [TestMethod]
        public void GetValue_KingCard_ReturnsThirteen()
        {
            Card card = new Card(Card.Suit.Clubs, Card.Rank.King);
            int value = card.GetValue();
            
            Assert.AreEqual(13, value);
        }

        [TestMethod]
        public void GetName_ValidCard_ReturnsCorrectFormat()
        {
            Card card = new Card(Card.Suit.Diamonds, Card.Rank.Queen);
            string name = card.GetName();
            
            Assert.AreEqual("Queen of Diamonds", name);
        }

        [TestMethod]
        public void Equals_SameCards_ReturnsTrue()
        {
            Card card1 = new Card(Card.Suit.Hearts, Card.Rank.Five);
            Card card2 = new Card(Card.Suit.Hearts, Card.Rank.Five);
            
            Assert.IsTrue(card1.Equals(card2));
        }

        [TestMethod]
        public void Equals_DifferentCards_ReturnsFalse()
        {
            Card card1 = new Card(Card.Suit.Hearts, Card.Rank.Five);
            Card card2 = new Card(Card.Suit.Spades, Card.Rank.Five);
            
            Assert.IsFalse(card1.Equals(card2));
        }
    }
}