using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] demensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string[,] matrix = new string[demensions[0], demensions[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] curRow = Console.ReadLine().Split();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = curRow[col];
                }
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split();
                string action = command[0];

                if (action == "END")
                {
                    break;
                }
                else if (action == "swap" && command.Length == 5)
                {
                    int row1 = int.Parse(command[1]);
                    int col1 = int.Parse(command[2]);
                    int row2 = int.Parse(command[3]);
                    int col2 = int.Parse(command[4]);

                    if (row1 >= matrix.GetLength(0) && row2 >= matrix.GetLength(0) &&
                        col1 >= matrix.GetLength(1) && col2 >= matrix.GetLength(1))
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }

                    string row1col1 = matrix[row1, col1];
                    string row2col2 = matrix[row2, col2];

                    matrix[row1, col1] = row2col2;
                    matrix[row2, col2] = row1col1;

                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            Console.Write(matrix[row, col] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

            }
        }
    }
}
