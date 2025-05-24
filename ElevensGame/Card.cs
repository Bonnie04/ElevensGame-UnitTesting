// Card.cs
namespace ElevensGame
{
    public class Card
    {
        public enum Suit
        {
            Hearts,
            Diamonds,
            Clubs,
            Spades
        }

        public enum Rank
        {
            Ace = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 11,
            Queen = 12,
            King = 13
        }

        public Suit CardSuit { get; private set; }
        public Rank CardRank { get; private set; }

        public Card(Suit suit, Rank rank)
        {
            CardSuit = suit;
            CardRank = rank;
        }

        public int GetValue()
        {
            return (int)CardRank;
        }

        public string GetName()
        {
            return $"{CardRank} of {CardSuit}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Card other)
            {
                return CardSuit == other.CardSuit && CardRank == other.CardRank;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(CardSuit, CardRank);
        }

        public override string ToString()
        {
            return GetName();
        }
    }
}