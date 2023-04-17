using System;

namespace _09._Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfInputs = int.Parse(Console.ReadLine());
            int rightSum = 0;
            int leftSum = 0;
            for (int counter = 0; counter < 2*countOfInputs; counter++)
            {
                int currentNumber=int.Parse(Console.ReadLine());
                if (counter < countOfInputs)
                {
                    rightSum+=currentNumber;
                }
                else
                {
                    leftSum+=currentNumber;
                }
            }
            if (rightSum == leftSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
            }

        }
    }
}
