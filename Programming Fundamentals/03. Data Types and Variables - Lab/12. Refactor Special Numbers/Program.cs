using System;

namespace _12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                bool IsTheSumEqualToFiveSevenOrEleven = false;
                int totalSum = 0;
                int currentNum = i;

                while (currentNum > 0)
                {
                    totalSum += currentNum % 10;
                    currentNum /= 10;
                }

                IsTheSumEqualToFiveSevenOrEleven = (totalSum == 5) || (totalSum == 7) || (totalSum == 11);

                Console.WriteLine("{0} -> {1}", i, IsTheSumEqualToFiveSevenOrEleven);
            }
        }
    }
}
