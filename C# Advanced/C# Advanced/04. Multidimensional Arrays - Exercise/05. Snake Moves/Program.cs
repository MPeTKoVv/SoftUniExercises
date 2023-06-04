using System;
using System.Linq;

namespace _5._Snake_Moves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] demensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            char[,] matrix = new char[demensions[0], demensions[1]];

            string snake = Console.ReadLine();

            int currSnakeIndex = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = snake[currSnakeIndex];

                        if (currSnakeIndex + 1 == snake.Length)
                        {
                            currSnakeIndex = -1;
                        }

                        currSnakeIndex++;
                    }
                }
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snake[currSnakeIndex];

                        if (currSnakeIndex + 1 == snake.Length)
                        {
                            currSnakeIndex = -1;
                        }

                        currSnakeIndex++;
                    }
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
