// Deck.cs
using System;
using System.Collections.Generic;
using System.Linq;

namespace ElevensGame
{
    public class Deck
    {
        private List<Card> cards;
        private Random random;

        public int Count => cards.Count;

        public Deck()
        {
            random = new Random();
            InitializeDeck();
        }

        private void InitializeDeck()
        {
            cards = new List<Card>();
            
            foreach (Card.Suit suit in Enum.GetValues<Card.Suit>())
            {
                foreach (Card.Rank rank in Enum.GetValues<Card.Rank>())
                {
                    cards.Add(new Card(suit, rank));
                }
            }
        }

        public void Shuffle()
        {
            // Fisher-Yates shuffle algorithm (as mentioned in lecture)
            for (int i = cards.Count - 1; i > 0; i--)
            {
                int randomIndex = random.Next(i + 1);
                SwapCards(i, randomIndex);
            }
        }

        private void SwapCards(int index1, int index2)
        {
            Card temp = cards[index1];
            cards[index1] = cards[index2];
            cards[index2] = temp;
        }

        public void Cut(int position)
        {
            if (position <= 0 || position >= cards.Count)
            {
                return; // No change for edge cases
            }

            List<Card> topPortion = cards.Take(position).ToList();
            List<Card> bottomPortion = cards.Skip(position).ToList();
            
            cards.Clear();
            cards.AddRange(bottomPortion);
            cards.AddRange(topPortion);
        }

        public Card TakeTopCard()
        {
            if (cards.Count == 0)
            {
                throw new InvalidOperationException("Cannot take card from empty deck");
            }

            Card topCard = cards[0];
            cards.RemoveAt(0);
            return topCard;
        }

        public Card PeekTopCard()
        {
            if (cards.Count == 0)
            {
                return null;
            }
            return cards[0];
        }

        public bool IsEmpty()
        {
            return cards.Count == 0;
        }

        public List<Card> GetCards()
        {
            return new List<Card>(cards); // Return copy to prevent external modification
        }
    }
}