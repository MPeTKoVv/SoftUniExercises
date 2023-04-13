using System;

namespace P08.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int trainingPrice = int.Parse(Console.ReadLine());
            double sneakersPrice = 0.6 * trainingPrice;
            double kitPrice = 0.8 * sneakersPrice;
            double basketballPrice = 0.25 * kitPrice;
            double accessoriesPrice = 0.2 * basketballPrice;
            double finalPrice = trainingPrice + sneakersPrice + kitPrice + basketballPrice + accessoriesPrice;
            Console.WriteLine(finalPrice);
        }

    }
}
