using System;

namespace _02._Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amountOfInputs = int.Parse(Console.ReadLine());
            int maxValue = int.MinValue;
            int sum = 0;
            for (int counter = 0; counter < amountOfInputs; counter++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                sum += currentNum;
                if (currentNum > maxValue)
                {
                    maxValue = currentNum;
                }
            }

            if (sum - maxValue == maxValue)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxValue}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sum - 2 * maxValue)}");
            }
        }
    }
}
