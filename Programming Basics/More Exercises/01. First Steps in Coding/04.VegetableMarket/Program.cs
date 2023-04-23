using System;

namespace _04.VegetableMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {       
            double vegPricePerKg=double.Parse(Console.ReadLine());
            double fruitPricePerKg = double.Parse(Console.ReadLine());
            double vegKg = double.Parse(Console.ReadLine());
            double fruitKg=double.Parse(Console.ReadLine());
            double vegPrice = vegPricePerKg * vegKg;
            double fruitPrice = fruitPricePerKg * fruitKg;
            double sumBGN = vegPrice + fruitPrice;
            double sumEUR = sumBGN / 1.94;
            Console.WriteLine($"{sumEUR:f2}");

        }
    }
}
