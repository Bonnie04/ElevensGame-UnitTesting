using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElevensGame;

namespace ElevensGame.Tests
{
    [TestClass]
    public class DeckTests
    {
        [TestMethod]
        public void Constructor_NewDeck_Has52Cards()
        {
            Deck deck = new Deck();
            Assert.AreEqual(52, deck.CardsRemaining);
        }

        [TestMethod]
        public void Deal_NonEmptyDeck_ReturnsCardAndDecreasesCount()
        {
            Deck deck = new Deck();
            int initialCount = deck.CardsRemaining;
            Card card = deck.Deal();
            
            Assert.IsNotNull(card);
            Assert.AreEqual(initialCount - 1, deck.CardsRemaining);
        }

        [TestMethod]
        public void IsEmpty_NewDeck_ReturnsFalse()
        {
            Deck deck = new Deck();
            Assert.IsFalse(deck.IsEmpty);
        }

        [TestMethod]
        public void HasCards_NewDeck_ReturnsTrue()
        {
            Deck deck = new Deck();
            Assert.IsTrue(deck.HasCards());
        }

        [TestMethod]
        public void Reset_AfterDealing_RestoresIndex()
        {
            Deck deck = new Deck();
            deck.Deal();
            deck.Deal();
            
            deck.Reset();
            
            Assert.AreEqual(52, deck.CardsRemaining);
        }
    }
}