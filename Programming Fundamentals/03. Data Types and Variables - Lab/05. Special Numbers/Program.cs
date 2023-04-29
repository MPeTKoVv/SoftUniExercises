using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int sumOfDigits = 0;
                int currentNum = i;

                while (currentNum > 0)
                {
                    sumOfDigits += currentNum % 10;
                    currentNum /= 10;
                }

                Console.WriteLine($"{i} -> {sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11}");
            }
        }
    }
}
