using System;
namespace Lab_5
{
    public class Board
    {
        private char[,] board;

        public Board()
        {
            board = new char[3, 3];
            MakeBoard();
        }
        private void MakeBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = '-';
                }
            }
        }

        public Memento SaveState()
        {
            return new Memento((char[,])board.Clone());
        }
        public void RestoreState(Memento memento)
        {
            board = memento.GetState();
        }
        public bool IsCellEmpty(int row, int col)
        {
            return board[row - 1, col - 1] == '-';
        }
       
        public void MakeMove(int row, int col, char playerSymbol)
        {
            board[row - 1, col - 1] = playerSymbol;
        }
        public char[,] GetBoard()
        {
            return board;
        }
    }
}
