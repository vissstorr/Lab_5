using System;
namespace Lab_5
{
    public class GameController
    {
        private GameMemory _gameMemory;
        public GameController(GameMemory gameMemory)
        {
            _gameMemory = gameMemory;
        }
        public void Play(int row,int col,char player)
        {
            _gameMemory.BackUp();
            _gameMemory.Board().MakeMove(row, col, player);
            GetBoard.PrintBoard(_gameMemory.Board().GetBoard());
            if (CheckingWin.CheckWin(_gameMemory.Board().GetBoard(), player))
            {
                Console.WriteLine("Гравець {0} переміг!", player);
                Environment.Exit(0);
            }
            
        }
        public void Reverse()
        {
            _gameMemory.Undo();
            GetBoard.PrintBoard(_gameMemory.Board().GetBoard());
        }
        
        public bool IsEmpty(int row, int col)
        {
            return _gameMemory.Board().IsCellEmpty(row, col);
        }
    }
}
