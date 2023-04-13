using System;

namespace P03._DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositedAmount = double.Parse(Console.ReadLine());
            int term = int.Parse(Console.ReadLine());
            double percent=double.Parse(Console.ReadLine());
            double finalAmount = depositedAmount + term * ((depositedAmount * (percent / 100)) / 12);
            Console.WriteLine(finalAmount);
        }

    }
}
