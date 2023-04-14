using System;

namespace _05.GodzillaVSKong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal budget=decimal.Parse(Console.ReadLine());
            int statistsAmount=int.Parse(Console.ReadLine());
            decimal clothesPricePerOnePerson=decimal.Parse(Console.ReadLine());

            if (statistsAmount > 150) clothesPricePerOnePerson = 0.9m * clothesPricePerOnePerson;
            decimal clothesPrice = clothesPricePerOnePerson * statistsAmount;
            decimal decor = 0.1m * budget;

            decimal remainingMoney = budget - (clothesPrice+decor);
            decimal notEnoghMoney = (clothesPrice + decor) - budget;
            if (budget < (decor + clothesPrice))
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {notEnoghMoney:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {remainingMoney:f2} leva left.");
            }
        }
    }
}
