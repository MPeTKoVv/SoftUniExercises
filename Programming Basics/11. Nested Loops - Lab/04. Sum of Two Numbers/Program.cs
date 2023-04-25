using System;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int firstNumber = startNumber;
            int secondNumber = startNumber;
            int combinationsCnt = 0;
            bool isReached = false;

            for (firstNumber = startNumber; firstNumber <= endNumber; firstNumber++)
            {
                for (secondNumber = startNumber; secondNumber <= endNumber; secondNumber++)
                {
                    combinationsCnt++;
                    if (firstNumber + secondNumber == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combinationsCnt} ({firstNumber} + {secondNumber} = {magicNumber})");
                        return;
                    }
                }
            }
            if (!isReached)
            {
                Console.WriteLine($"{combinationsCnt} combinations - neither equals {magicNumber}");
            }
        }
    }
}
