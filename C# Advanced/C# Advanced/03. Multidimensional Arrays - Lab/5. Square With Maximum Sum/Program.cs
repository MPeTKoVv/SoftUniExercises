using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[size[0], size[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            int biggestSum = 0;

            int[,] biggestSumMatrix =
            {
                {0, 0},
                {0, 0}
            };

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int currSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (currSum > biggestSum)
                    {
                        biggestSum = currSum;

                        biggestSumMatrix[0, 0] = matrix[row, col];
                        biggestSumMatrix[0, 1] = matrix[row, col + 1];
                        biggestSumMatrix[1, 0] = matrix[row + 1, col];
                        biggestSumMatrix[1, 1] = matrix[row + 1, col + 1];
                    }
                }
            }

            for (int row = 0; row < biggestSumMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < biggestSumMatrix.GetLength(1); col++)
                {
                    Console.Write(biggestSumMatrix[row, col] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(biggestSum);
        }
    }
}
