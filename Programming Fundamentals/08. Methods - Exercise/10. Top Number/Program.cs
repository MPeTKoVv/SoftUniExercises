using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                bool isItsSumOfDigitsValid = IsItsSumOfDigitsValid(i);
                bool doesItHoldLeastOneOddDigit = DoesItHoldLeastOneOddDigit(i);

                if (isItsSumOfDigitsValid && doesItHoldLeastOneOddDigit)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool DoesItHoldLeastOneOddDigit(int number)
        {
            int cnt = 0;

            while (number > 0)
            {
                int currentDigit = number % 10;
                number /= 10;

                if (currentDigit % 2 != 0)
                {
                    cnt++;
                }
                else
                {
                    continue;
                }

                if (cnt == 2)
                {
                    return true;
                }
                else
                {
                    continue;
                }
            }

            return false;
        }

        private static bool IsItsSumOfDigitsValid(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            if (sum % 8 == 0)
            {
                return true;
            }

            return false;
        }
    }
}
