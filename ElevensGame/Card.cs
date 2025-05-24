namespace ElevensGame
{
    public class Card
    {
        private string rank;
        private string suit;
        private bool faceUp;

        public string Rank { get { return rank; } }
        public string Suit { get { return suit; } }
        public bool FaceUp 
        { 
            get { return faceUp; } 
            set { faceUp = value; } 
        }
        
        public int PointValue 
        { 
            get 
            {
                switch (rank.ToLower())
                {
                    case "ace": return 1;
                    case "2": case "two": return 2;
                    case "3": case "three": return 3;
                    case "4": case "four": return 4;
                    case "5": case "five": return 5;
                    case "6": case "six": return 6;
                    case "7": case "seven": return 7;
                    case "8": case "eight": return 8;
                    case "9": case "nine": return 9;
                    case "10": case "ten": return 10;
                    case "jack": return 11;
                    case "queen": return 12;
                    case "king": return 13;
                    default: return 0;
                }
            }
        }

        public Card(string rank, string suit)
        {
            this.rank = rank;
            this.suit = suit;
            this.faceUp = true;
        }

        public void FlipOver()
        {
            faceUp = !faceUp;
        }

        public override string ToString()
        {
            return $"{rank} of {suit}";
        }

        public bool Equals(Card other)
        {
            if (other == null) return false;
            return rank.Equals(other.rank, StringComparison.OrdinalIgnoreCase) && 
                   suit.Equals(other.suit, StringComparison.OrdinalIgnoreCase);
        }
    }
}