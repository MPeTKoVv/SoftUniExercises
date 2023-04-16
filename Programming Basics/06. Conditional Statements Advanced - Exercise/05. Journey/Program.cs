using System;

namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string campOrHotel = string.Empty;
            double spendedMoneyPercent = 0;
            double price = 0;
            string place = string.Empty;

            if (budget > 1000)
            {
                place = "Europe";
                campOrHotel = "Hotel";
                spendedMoneyPercent = 0.9;
            }
            else if (budget > 100)
            {
                place = "Balkans";
                if (season == "summer")
                {
                    campOrHotel = "Camp";
                    spendedMoneyPercent = 0.40;
                }
                else
                {
                    campOrHotel = "Hotel";
                    spendedMoneyPercent = 0.80;
                }
            }
            else
            {
                place = "Bulgaria";
                if (season == "summer")
                {
                    campOrHotel = "Camp";
                    spendedMoneyPercent = 0.30;
                }
                else
                {
                    campOrHotel = "Hotel";
                    spendedMoneyPercent = 0.70;
                }
            }
            price = spendedMoneyPercent * budget;
            Console.WriteLine($"Somewhere in {place}");
            Console.WriteLine($"{campOrHotel} - {price:f2}");

        }
    }
}
