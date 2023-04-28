using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double totalPrice = 0;
            totalPrice += lostGamesCount / 2 * headsetPrice;
            totalPrice += lostGamesCount / 3 * mousePrice;
            totalPrice += lostGamesCount / 6 * keyboardPrice;
            totalPrice += lostGamesCount / 12 * displayPrice;

            Console.WriteLine($"Rage expenses: {totalPrice:f2} lv.");
        }
    }
}
