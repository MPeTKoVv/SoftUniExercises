
using System;

namespace P07.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chicken = 10.35;
            double fish = 12.4;
            double veg = 8.15;
            double delivery = 2.5;

            int chickenMenu = int.Parse(Console.ReadLine());
            int fihsMenu=int.Parse(Console.ReadLine());
            int vegMenu=int.Parse(Console.ReadLine());

            double menuPrice = chicken * chickenMenu + fish * fihsMenu + veg * vegMenu;
            double dessert = 0.2 * menuPrice;
            double finalPrice = menuPrice + dessert + delivery;
            Console.WriteLine(finalPrice);
        }
    }
}
