using System;
using System.Collections.Generic;

namespace ElevensGame
{
    public class Deck
    {
        private List<Card> cards;
        private int currentIndex;

        public int CardsRemaining { get { return cards.Count - currentIndex; } }
        public bool IsEmpty { get { return currentIndex >= cards.Count; } }

        public Deck()
        {
            cards = new List<Card>();
            currentIndex = 0;
            InitializeDeck();
        }

        private void InitializeDeck()
        {
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] ranks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            foreach (string suit in suits)
            {
                foreach (string rank in ranks)
                {
                    cards.Add(new Card(rank, suit));
                }
            }
        }

        public void Shuffle()
        {
            Random random = new Random();
            for (int i = cards.Count - 1; i > 0; i--)
            {
                int randomIndex = random.Next(i + 1);
                Card temp = cards[i];
                cards[i] = cards[randomIndex];
                cards[randomIndex] = temp;
            }
        }

        public Card Deal()
        {
            if (IsEmpty)
                return null;
            
            Card card = cards[currentIndex];
            currentIndex++;
            return card;
        }

        public void Reset()
        {
            currentIndex = 0;
        }

        public bool HasCards()
        {
            return !IsEmpty;
        }

        // Keep old methods for compatibility
        public Card TakeTopCard()
        {
            return Deal();
        }

        public Card PeekTopCard()
        {
            if (IsEmpty)
                return null;
            return cards[currentIndex];
        }

        public int Count => CardsRemaining;
    }
}