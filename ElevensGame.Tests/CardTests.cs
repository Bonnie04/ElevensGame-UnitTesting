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
            Card card = new Card("Ace", "Hearts");
            
            Assert.AreEqual("Hearts", card.Suit);
            Assert.AreEqual("Ace", card.Rank);
        }

        [TestMethod]
        public void PointValue_AceCard_ReturnsOne()
        {
            Card card = new Card("Ace", "Spades");
            
            Assert.AreEqual(1, card.PointValue);
        }

        [TestMethod]
        public void PointValue_KingCard_ReturnsThirteen()
        {
            Card card = new Card("King", "Clubs");
            
            Assert.AreEqual(13, card.PointValue);
        }

        [TestMethod]
        public void ToString_ValidCard_ReturnsCorrectFormat()
        {
            Card card = new Card("Queen", "Diamonds");
            
            Assert.AreEqual("Queen of Diamonds", card.ToString());
        }

        [TestMethod]
        public void Equals_SameCards_ReturnsTrue()
        {
            Card card1 = new Card("5", "Hearts");
            Card card2 = new Card("5", "Hearts");
            
            Assert.IsTrue(card1.Equals(card2));
        }

        [TestMethod]
        public void FlipOver_ChangeFaceUpState()
        {
            Card card = new Card("Ace", "Hearts");
            bool initialState = card.FaceUp;
            
            card.FlipOver();
            
            Assert.AreNotEqual(initialState, card.FaceUp);
        }
    }
}