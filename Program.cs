using Lab_5.Interface;
using System;
using System.Collections.Generic;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            GameMemory game = new GameMemory();
            GameController gameController = new GameController(game);
            IRunner runner = new Runner(gameController);
            runner.Run();
        }
    }
}