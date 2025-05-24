// ElevensGame.cs
using System;
using System.Collections.Generic;
using System.Linq;

namespace ElevensGame
{
    public class ElevensGame
    {
        private Deck deck;
        private List<Card> board;
        private const int BOARD_SIZE = 9;
        private int movesCount;

        public List<Card> Board => new List<Card>(board);
        public int MovesCount => movesCount;
        public bool IsGameWon => deck.IsEmpty() && !HasValidMoves();
        public bool IsGameLost => !deck.IsEmpty() && !HasValidMoves();

        public ElevensGame()
        {
            InitializeGame();
        }

        public void InitializeGame()
        {
            deck = new Deck();
            deck.Shuffle();
            board = new List<Card>();
            movesCount = 0;
            
            // Deal initial 9 cards to the board
            for (int i = 0; i < BOARD_SIZE && !deck.IsEmpty(); i++)
            {
                board.Add(deck.TakeTopCard());
            }
        }

        public bool HasValidMoves()
        {
            // Check for pairs that sum to 11
            for (int i = 0; i < board.Count; i++)
            {
                for (int j = i + 1; j < board.Count; j++)
                {
                    if (board[i] != null && board[j] != null)
                    {
                        if (board[i].GetValue() + board[j].GetValue() == 11)
                        {
                            return true;
                        }
                    }
                }
            }

            // Check for Jack, Queen, King combination
            bool hasJack = board.Any(c => c?.CardRank == Card.Rank.Jack);
            bool hasQueen = board.Any(c => c?.CardRank == Card.Rank.Queen);
            bool hasKing = board.Any(c => c?.CardRank == Card.Rank.King);

            return hasJack && hasQueen && hasKing;
        }

        public bool RemovePairSumToEleven(int index1, int index2)
        {
            if (!IsValidIndex(index1) || !IsValidIndex(index2) || index1 == index2)
                return false;

            Card card1 = board[index1];
            Card card2 = board[index2];

            if (card1 == null || card2 == null)
                return false;

            if (card1.GetValue() + card2.GetValue() == 11)
            {
                board[index1] = null;
                board[index2] = null;
                movesCount++;
                FillEmptySpots();
                return true;
            }

            return false;
        }

        public bool RemoveJQK(int jackIndex, int queenIndex, int kingIndex)
        {
            if (!IsValidIndex(jackIndex) || !IsValidIndex(queenIndex) || !IsValidIndex(kingIndex))
                return false;

            if (jackIndex == queenIndex || jackIndex == kingIndex || queenIndex == kingIndex)
                return false;

            Card jack = board[jackIndex];
            Card queen = board[queenIndex];
            Card king = board[kingIndex];

            if (jack?.CardRank == Card.Rank.Jack && 
                queen?.CardRank == Card.Rank.Queen && 
                king?.CardRank == Card.Rank.King)
            {
                board[jackIndex] = null;
                board[queenIndex] = null;
                board[kingIndex] = null;
                movesCount++;
                FillEmptySpots();
                return true;
            }

            return false;
        }

        private bool IsValidIndex(int index)
        {
            return index >= 0 && index < board.Count;
        }

        private void FillEmptySpots()
        {
            for (int i = 0; i < board.Count; i++)
            {
                if (board[i] == null && !deck.IsEmpty())
                {
                    board[i] = deck.TakeTopCard();
                }
            }
        }

        public List<int> GetValidPairIndices()
        {
            List<int> validPairs = new List<int>();
            
            for (int i = 0; i < board.Count; i++)
            {
                for (int j = i + 1; j < board.Count; j++)
                {
                    if (board[i] != null && board[j] != null)
                    {
                        if (board[i].GetValue() + board[j].GetValue() == 11)
                        {
                            validPairs.Add(i);
                            validPairs.Add(j);
                        }
                    }
                }
            }
            
            return validPairs;
        }

        public List<int> GetJQKIndices()
        {
            List<int> jqkIndices = new List<int>();
            
            for (int i = 0; i < board.Count; i++)
            {
                if (board[i] != null)
                {
                    var rank = board[i].CardRank;
                    if (rank == Card.Rank.Jack || rank == Card.Rank.Queen || rank == Card.Rank.King)
                    {
                        jqkIndices.Add(i);
                    }
                }
            }
            
            return jqkIndices;
        }
    }
}