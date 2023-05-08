using System;

namespace _07._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Matrix(num);
        }

        private static void Matrix(int num)
        {
            for (int rows = 0; rows < num; rows++)
            {
                for (int cols = 0; cols < num; cols++)
                {
                    Console.Write($"{num} ");
                }

                Console.WriteLine();
            }
        }
    }
}
