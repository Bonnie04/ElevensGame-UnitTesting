using System;

namespace ElevensGame
{
    public class Board
    {
        private Card[] boardCards;
        private Deck deck;

       public bool GameWon 
{ 
    get 
    { 
        return deck.IsEmpty && !HasValidMoves(); // Add () here
    } 
}
        
    public bool GameLost 
{ 
    get 
    { 
        return !deck.IsEmpty && !HasValidMoves(); // Add () here
    } 
}
        public Board()
        {
            boardCards = new Card[9];
            deck = new Deck();
            InitializeBoard();
        }

        public void InitializeBoard()
        {
            deck.Shuffle();
            for (int i = 0; i < 9; i++)
            {
                boardCards[i] = deck.Deal();
            }
        }

        public bool SelectCards(int[] indices)
        {
            if (IsValidPlay(indices))
            {
                ReplaceCards(indices);
                return true;
            }
            return false;
        }

        public void ReplaceCards(int[] indices)
        {
            foreach (int index in indices)
            {
                boardCards[index] = null;
            }

            for (int i = 0; i < 9; i++)
            {
                if (boardCards[i] == null && deck.HasCards())
                {
                    boardCards[i] = deck.Deal();
                }
            }
        }

        public bool IsValidPlay(int[] indices)
        {
            if (indices.Length == 2)
            {
                // Check for pair summing to 11
                Card card1 = GetCard(indices[0]);
                Card card2 = GetCard(indices[1]);
                if (card1 != null && card2 != null)
                {
                    return card1.PointValue + card2.PointValue == 11;
                }
            }
            else if (indices.Length == 3)
            {
                // Check for Jack, Queen, King
                Card card1 = GetCard(indices[0]);
                Card card2 = GetCard(indices[1]);
                Card card3 = GetCard(indices[2]);
                
                if (card1 != null && card2 != null && card3 != null)
                {
                    bool hasJack = card1.Rank == "Jack" || card2.Rank == "Jack" || card3.Rank == "Jack";
                    bool hasQueen = card1.Rank == "Queen" || card2.Rank == "Queen" || card3.Rank == "Queen";
                    bool hasKing = card1.Rank == "King" || card2.Rank == "King" || card3.Rank == "King";
                    
                    return hasJack && hasQueen && hasKing;
                }
            }
            return false;
        }

        public bool CheckForWin()
        {
            return GameWon;
        }

        public bool HasValidMoves()
        {
            // Check for pairs summing to 11
            for (int i = 0; i < 9; i++)
            {
                for (int j = i + 1; j < 9; j++)
                {
                    if (boardCards[i] != null && boardCards[j] != null)
                    {
                        if (boardCards[i].PointValue + boardCards[j].PointValue == 11)
                        {
                            return true;
                        }
                    }
                }
            }

            // Check for Jack, Queen, King combination
            bool hasJack = false, hasQueen = false, hasKing = false;
            for (int i = 0; i < 9; i++)
            {
                if (boardCards[i] != null)
                {
                    if (boardCards[i].Rank == "Jack") hasJack = true;
                    if (boardCards[i].Rank == "Queen") hasQueen = true;
                    if (boardCards[i].Rank == "King") hasKing = true;
                }
            }

            return hasJack && hasQueen && hasKing;
        }

        public Card GetCard(int index)
        {
            if (index >= 0 && index < 9)
            {
                return boardCards[index];
            }
            return null;
        }
    }
}