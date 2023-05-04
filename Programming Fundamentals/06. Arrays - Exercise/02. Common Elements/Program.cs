using System;

namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            string[] input1Array = input1.Split(" ");
            string[] input2Array = input2.Split(" ");

            foreach (string currentIndexIninput2Array in input2Array)
            {
                foreach (string currentIndexIninput1Array in input1Array)
                {
                    if (currentIndexIninput2Array == currentIndexIninput1Array)
                    {
                        Console.Write($"{currentIndexIninput2Array} ");
                    }
                }
            }
        }
    }
}
