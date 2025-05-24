using System.Collections.Generic;

namespace ElevensGame
{
    public class Player
    {
        public string Name { get; private set; }
        public List<Card> Hand { get; private set; }
        public int Score { get; set; }

        public Player(string name)
        {
            Name = name;
            Hand = new List<Card>();
            Score = 0;
        }

        public void AddCard(Card card)
        {
            if (card != null)
            {
                Hand.Add(card);
            }
        }

        public bool RemoveCard(Card card)
        {
            return Hand.Remove(card);
        }

        public void ClearHand()
        {
            Hand.Clear();
        }

        public int GetHandSize()
        {
            return Hand.Count;
        }
    }
}