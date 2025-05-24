using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElevensGame;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ElevensGame.Tests
{
    [TestClass]
    public class DeckTests
    {
        [TestMethod]
        public void Constructor_NewDeck_Has52Cards()
        {
            Deck deck = new Deck();
            Assert.AreEqual(52, deck.Count);
        }

        [TestMethod]
        public void TakeTopCard_NonEmptyDeck_ReturnsCardAndDecreasesCount()
        {
            Deck deck = new Deck();
            int initialCount = deck.Count;
            Card card = deck.TakeTopCard();
            
            Assert.IsNotNull(card);
            Assert.AreEqual(initialCount - 1, deck.Count);
        }

        [TestMethod]
        public void TakeTopCard_EmptyDeck_ThrowsException()
        {
            Deck deck = new Deck();
            while (!deck.IsEmpty())
            {
                deck.TakeTopCard();
            }
            
            Assert.ThrowsException<InvalidOperationException>(() => deck.TakeTopCard());
        }

        [TestMethod]
        public void Cut_ValidPosition_ChangesCardOrder()
        {
            Deck deck = new Deck();
            Card originalTop = deck.PeekTopCard();
            deck.Cut(26);
            Card newTop = deck.PeekTopCard();
            
            Assert.AreNotEqual(originalTop, newTop);
        }

        [TestMethod]
        public void Shuffle_ChangesDeckOrder()
        {
            Deck deck = new Deck();
            var originalOrder = deck.GetCards();
            deck.Shuffle();
            var shuffledOrder = deck.GetCards();
            
            CollectionAssert.AreNotEqual(originalOrder, shuffledOrder);
        }

        [TestMethod]
        public void Shuffle_MultipleShuffles_EachCardMovesAtLeastOnce()
        {
            Deck deck = new Deck();
            var originalPositions = new Dictionary<Card, int>();
            var cards = deck.GetCards();
            
            for (int i = 0; i < cards.Count; i++)
            {
                originalPositions[cards[i]] = i;
            }
            
            bool[] cardMoved = new bool[52];
            
            for (int shuffle = 0; shuffle < 10; shuffle++)
            {
                deck.Shuffle();
                var currentCards = deck.GetCards();
                
                for (int i = 0; i < currentCards.Count; i++)
                {
                    if (originalPositions[currentCards[i]] != i)
                    {
                        cardMoved[originalPositions[currentCards[i]]] = true;
                    }
                }
            }
            
            int movedCount = cardMoved.Count(moved => moved);
            Assert.IsTrue(movedCount > 40, $"Only {movedCount} cards moved position during shuffles");
        }

        [TestMethod]
        public void IsEmpty_NewDeck_ReturnsFalse()
        {
            Deck deck = new Deck();
            Assert.IsFalse(deck.IsEmpty());
        }

        [TestMethod]
        public void IsEmpty_EmptyDeck_ReturnsTrue()
        {
            Deck deck = new Deck();
            while (!deck.IsEmpty())
            {
                deck.TakeTopCard();
            }
            
            Assert.IsTrue(deck.IsEmpty());
        }
    }
}