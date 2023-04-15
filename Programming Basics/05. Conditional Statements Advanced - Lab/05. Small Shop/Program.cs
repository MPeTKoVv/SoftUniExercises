using System;

namespace _05._Small_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            decimal amount = decimal.Parse(Console.ReadLine());
            decimal price;

            /* 
                	coffee	water	beer	sweets	peanuts
            Sofia	0.50	0.80	1.20	1.45	1.60
            Plovdiv	0.40	0.70	1.15	1.30	1.50
            Varna	0.45	0.70	1.10	1.35	1.55
            */

            if (product == "coffee")
            {
                if (city == "Sofia") price = 0.5m * amount;
                else if (city == "Plovdiv") price = 0.4m * amount;
                else price = 0.45m * amount;
            }
            else if (product == "water")
            {
                if (city == "Sofia") price = 0.8m * amount;
                else if (city == "Plovdiv") price = 0.7m * amount;
                else price = 0.7m * amount;
            }
            else if (product == "beer")
            {
                if (city == "Sofia") price = 1.2m * amount;
                else if (city == "Plovdiv") price = 1.15m * amount;
                else price = 1.1m * amount;
            }
            else if (product == "sweets")
            {
                if (city == "Sofia") price = 1.45m * amount;
                else if (city == "Plovdiv") price = 1.30m * amount;
                else price = 1.35m * amount;
            }
            else
            {
                if (city == "Sofia") price = 1.6m * amount;
                else if (city == "Plovdiv") price = 1.5m * amount;
                else price = 1.55m * amount;
            }
            Console.WriteLine(price);
        }
    }
}
