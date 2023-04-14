
using System;

namespace _07.Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int videocardsAmount = int.Parse(Console.ReadLine());
            int cpuAmount = int.Parse(Console.ReadLine());
            int ramAmount = int.Parse(Console.ReadLine());

            decimal videocardPricePerOne = 250.0m;
            decimal videocardPrice = videocardsAmount * videocardPricePerOne;
            decimal cpuPrice = 0.35m * videocardPrice;
            decimal ramPrice = 0.1m * videocardPrice;

            decimal totalPrice = videocardPrice + cpuAmount * cpuPrice + ramAmount * ramPrice;

            if (videocardsAmount > cpuAmount) totalPrice = totalPrice * 0.85m;

            decimal neededMoney = totalPrice - budget;
            decimal leftMoney = budget - totalPrice;

            if (budget >= totalPrice) Console.WriteLine($"You have {leftMoney:f2} leva left!");
            else if (budget < totalPrice) Console.WriteLine($"Not enough money! You need {neededMoney:f2} leva more!");
        }
    }
}
