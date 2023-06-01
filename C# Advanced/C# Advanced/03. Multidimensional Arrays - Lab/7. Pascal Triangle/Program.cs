using System;

namespace _7._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            long[][] jaggedArray = new long[rows][];

            long currWidth = 1;

            for (int row = 0; row < rows; row++)
            {
                jaggedArray[row] = new long[currWidth];
                long[] currRow = jaggedArray[row];
                currRow[0] = 1;
                currRow[currRow.Length - 1] = 1;
                currWidth++;

                if (currRow.Length > 2)
                {
                    for (int i = 1; i < currRow.Length - 1; i++)
                    {
                        long[] previousRow = jaggedArray[row - 1];
                        long previousRowSum = previousRow[i] + previousRow[i - 1];
                        currRow[i] = previousRowSum;
                    }
                }

            }

            foreach (long[] row in jaggedArray)
            {
                Console.WriteLine(String.Join(" ", row));
            }
        }
    }
}
