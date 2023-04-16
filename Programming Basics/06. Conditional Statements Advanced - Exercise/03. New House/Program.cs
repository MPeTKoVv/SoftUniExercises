using System;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int flowerAmount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0;
            double rosePrice = 5;
            double dahliaPrice = 3.8;
            double tulipPrice = 2.8;
            double narcissusPrice = 3;
            double gladiolusPrice = 2.5;
            double discount = 1;

            if (flower == "Roses" && flowerAmount > 80)
            {
                discount = 0.9;
                price = rosePrice * flowerAmount;
            }
            else if (flower == "Dahlias" && flowerAmount > 90)
            {
                discount = 0.85;
                price = dahliaPrice * flowerAmount;
            }
            else if (flower == "Tulips" && flowerAmount > 80)
            {
                discount = 0.85;
                price = tulipPrice * flowerAmount;
            }
            else if (flower == "Narcissus" && flowerAmount < 120)
            {
                discount = 1.15;
                price = narcissusPrice * flowerAmount;
            }
            else if (flower == "Gladiolus" && flowerAmount < 80)
            {
                discount = 1.2;
                price = gladiolusPrice * flowerAmount;
            }
            else if (flower == "Roses")
            {
                price = rosePrice * flowerAmount;
            }
            else if (flower == "Dahlias")
            {
                price = dahliaPrice * flowerAmount;
            }
            else if (flower == "Tulips")
            {
                price = tulipPrice * flowerAmount;
            }
            else if (flower == "Narcissus")
            {
                price = narcissusPrice * flowerAmount;
            }
            else if (flower == "Gladiolus")
            {
                price = gladiolusPrice * flowerAmount;
            }
            price *= discount;
            double leftMoney = budget - price;
            double neededMoney = price - budget;

            if (budget >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowerAmount} {flower} and {leftMoney:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {neededMoney:f2} leva more.");
            }
        }
    }
}
