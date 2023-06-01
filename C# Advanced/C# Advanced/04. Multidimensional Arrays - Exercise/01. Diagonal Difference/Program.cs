using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int row = 0; row < size; row++)
            {
                int[] curRow = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = curRow[col];
                }
            }

            int upSum = 0;
            int downSum = 0;

            for (int row = 0; row < size; row++)
            {
                downSum += matrix[row, row];
            }
            for (int row = 0; row < size; row++)
            {
                upSum += matrix[row, size - 1 - row];
            }

            Console.WriteLine(Math.Abs(upSum - downSum));
        }
    }
}
