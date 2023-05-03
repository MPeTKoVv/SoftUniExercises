using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

            int oddSum = 0;
            int evenSum = 0;

            foreach (int item in numbers)
            {
                if (item % 2 == 0)
                {
                    evenSum += item;
                }
                else
                {
                    oddSum += item;
                }
            }

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        evenSum += numbers[i];
            //    }
            //    else
            //    {
            //        oddSum += numbers[i];
            //    }
            //}

            int result = evenSum - oddSum;

            Console.WriteLine(result);
        }
    }
}
