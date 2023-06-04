using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                jaggedArray[row] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }

            for (int row = 0; row < rows - 1; row++)
            {
                if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                {
                    for (int currCol = 0; currCol < jaggedArray[row].Length; currCol++)
                    {
                        jaggedArray[row][currCol] *= 2;
                    }
                    for (int currCol = 0; currCol < jaggedArray[row + 1].Length; currCol++)
                    {
                        jaggedArray[row + 1][currCol] *= 2;
                    }
                }
                else
                {
                    for (int currCol = 0; currCol < jaggedArray[row].Length; currCol++)
                    {
                        jaggedArray[row][currCol] /= 2;
                    }
                    for (int currCol = 0; currCol < jaggedArray[row + 1].Length; currCol++)
                    {
                        jaggedArray[row + 1][currCol] /= 2;
                    }
                }
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                string action = command[0];

                if (action == "End")
                {
                    break;
                }

                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);

                if (row >= 0 && row < jaggedArray.GetLength(0) &&
                    col >= 0 && col < jaggedArray[row].Length)
                {
                    if (action == "Add")
                    {
                        jaggedArray[row][col] += value;
                    }
                    else if (action == "Subtract")
                    {
                        jaggedArray[row][col] -= value;
                    }
                }
                else
                {
                    continue;
                }

            }

            for (int row = 0; row < jaggedArray.GetLength(0); row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write(jaggedArray[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
