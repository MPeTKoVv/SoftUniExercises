using System;

namespace _04._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            UpperPart(num);
            Height(num);
            DownPart(num);
        }

        private static void DownPart(int num)
        {
            for (int i = num; i >= 1; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        private static void Height(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        private static void UpperPart(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
