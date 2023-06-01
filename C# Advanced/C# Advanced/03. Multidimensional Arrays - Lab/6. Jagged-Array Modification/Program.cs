using System;

namespace _6._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[rows][];

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                string[] nums = Console.ReadLine().Split(' ');
                jaggedArray[row] = new int[nums.Length];

                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    jaggedArray[row][col] = int.Parse(nums[col]);
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

                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);

                if (jaggedArray.GetLength(0) > row && row >= 0 && jaggedArray[row].Length > col && col >= 0)
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
                    Console.WriteLine("Invalid coordinates");
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
