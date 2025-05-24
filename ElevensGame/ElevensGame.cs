using System;

namespace ElevensGame
{
    public class Game
    {
        private Board board;
        private bool isGameActive;

        public bool IsGameActive { get { return isGameActive; } }
        public Board CurrentBoard { get { return board; } }

        public Game()
        {
            board = new Board();
            isGameActive = true;
        }

        public void StartNewGame()
        {
            board = new Board();
            isGameActive = true;
        }

        public bool PlayCards(int[] indices)
        {
            if (!isGameActive) return false;
            
            bool validPlay = board.SelectCards(indices);
            
            if (board.GameWon || board.GameLost)
            {
                isGameActive = false;
            }
            
            return validPlay;
        }

        public void RestartGame()
        {
            StartNewGame();
        }

        public void EndGame()
        {
            isGameActive = false;
        }
    }
}