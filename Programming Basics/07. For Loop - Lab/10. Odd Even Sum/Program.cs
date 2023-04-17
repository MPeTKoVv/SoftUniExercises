using System;

namespace _10._Odd_Even_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfInputs = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;
            for (int counter = 0; counter < countOfInputs; counter++)
            {
                int num = int.Parse(Console.ReadLine());
                if (counter % 2 == 0)
                {
                    evenSum += num;
                }
                else
                {
                    oddSum += num;
                }
            }
            if (evenSum==oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenSum}");
            }    
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(oddSum-evenSum)}");
            }
        }
    }
}
