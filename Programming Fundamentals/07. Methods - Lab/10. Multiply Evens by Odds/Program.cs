using System;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);

            int evenSum = GetSumOfEvenDigits(number);
            int oddSum = GetSumOfOddDigits(number);

            Console.WriteLine(GetMultipleOfEvenAndOdds(evenSum, oddSum));
        }

        static int GetMultipleOfEvenAndOdds(int EvenSum, int OddSum)
        {
            int sum = EvenSum * OddSum;
            return sum;
        }
        static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                int currentDigit = number % 10;
                number /= 10;

                if (currentDigit % 2 == 0)
                {
                    sum += currentDigit;
                }
            }

            return sum;
        }
        static int GetSumOfOddDigits(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                int currentDigit = number % 10;
                number /= 10;

                if (currentDigit % 2 != 0)
                {
                    sum += currentDigit;
                }
            }

            return sum;
        }
    }
}
