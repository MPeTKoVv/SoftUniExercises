using System;

namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());
            double price = 0;
            double discount = 1;

            if (season == "Spring")
            {
                price = 3000;

                if (fishermen > 12)
                {
                    discount = 0.75;
                }
                else if (fishermen >= 7)
                {
                    discount = 0.85;
                }
                else
                {
                    discount = 0.9;
                }

            }
            else if (season == "Summer")
            {
                price = 4200;

                if (fishermen > 12)
                {
                    discount = 0.75;
                }
                else if (fishermen >= 7)
                {
                    discount = 0.85;
                }
                else
                {
                    discount = 0.9;
                }
            }
            else if (season == "Autumn")
            {
                price = 4200;

                if (fishermen > 12)
                {
                    discount = 0.75;
                }
                else if (fishermen >= 7)
                {
                    discount = 0.85;
                }
                else
                {
                    discount = 0.9;
                }
            }
            else if (season == "Winter")
            {
                price = 2600;

                if (fishermen > 12)
                {
                    discount = 0.75;
                }
                else if (fishermen >= 7)
                {
                    discount = 0.85;
                }
                else
                {
                    discount = 0.9;
                }
            }

            //switch (season)
            //{
            //    case "Spring":
            //        price = 3000;
            //        break;
            //    case "Summer":
            //    case "Autumn":
            //        price = 4200;
            //        break;
            //    case "Winter":
            //        price = 2600;
            //        break;
            //}
            //if (fishermen > 12)
            //{
            //    discount = 0.75;
            //}
            //else if (fishermen >= 7)
            //{
            //    discount = 0.85;
            //}
            //else
            //{
            //    discount = 0.9;
            //}

            price *= discount;
            if (fishermen % 2 == 0 && season != "Autumn")
            {
                discount = 0.95;
                price *= discount;
            }
            double leftMoney = budget - price;
            double neededMoney = Math.Abs(leftMoney);

            if (budget >= price)
            {
                Console.WriteLine($"Yes! You have {leftMoney:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {neededMoney:f2} leva.");
            }
        }
    }
}
