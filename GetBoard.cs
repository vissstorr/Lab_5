using System;
namespace Lab_5
{
    public static class GetBoard
    {
        public static void PrintBoard(char [,]board)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
