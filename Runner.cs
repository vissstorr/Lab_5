using Lab_5.Interface;
using System;
namespace Lab_5
{
    class Runner:IRunner
    {
        private GameController _game;
        public Runner(GameController game)
        {
          _game = game;
        }
        public void Run()
        {
            char currentPlayer = 'O';

            while (true)
            {
                Console.WriteLine("Гравець {0}, введіть координати ходу (рядок, стовпець):", currentPlayer);
                string input = Console.ReadLine();
                string[] coordinates = input.Split(',');
                if (coordinates.Length != 2
                    || !int.TryParse(coordinates[0], out int row) 
                    || !int.TryParse(coordinates[1], out int col)
                    || row < 1 || row > 3 || col < 1 || col > 3)
                {
                    Console.WriteLine("Некоректний ввід. Введіть координати у форматі 'рядок,стовпець'.");
                    continue;
                }
                if (!_game.IsEmpty(row, col))
                {
                    Console.WriteLine("Ця клітинка вже зайнята. Виберіть іншу клітинку.");
                    continue;
                }
                _game.Play(row, col, currentPlayer);
                currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
                Console.WriteLine("Бажаєте зробити крок назад? (y/n)");
                string choice = Console.ReadLine();
                if (choice.ToLower() == "y")
                {
                    _game.Reverse();
                    currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
                }
            }
        }
    }
}
