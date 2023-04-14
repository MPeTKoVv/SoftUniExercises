using System;

namespace _04.ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal puzzlePrice = 2.6m;
            decimal dollPrice = 3m;
            decimal teddybearPrice = 4.1m;
            decimal minionPrice = 8.2m;
            decimal truckPrice = 2m;

            decimal tripPrice=decimal.Parse(Console.ReadLine());
            int puzzleAmount=int.Parse(Console.ReadLine());
            int dollAmount=int.Parse(Console.ReadLine());
            int teddybearAmount=int.Parse(Console.ReadLine());
            int minionAmount=int.Parse(Console.ReadLine());
            int truckAmount=int.Parse(Console.ReadLine());

            int totalAmount = puzzleAmount + dollAmount + teddybearAmount + minionAmount + truckAmount;
            decimal toyPrice = puzzlePrice * puzzleAmount + dollPrice * dollAmount + teddybearPrice * teddybearAmount + minionPrice * minionAmount + truckPrice * truckAmount;

            if (totalAmount >= 50) toyPrice = 0.75m * toyPrice;

            decimal rent = 0.1m * toyPrice;

            decimal remainingMoney = toyPrice - rent;
            decimal leftMoney = remainingMoney - tripPrice;
            decimal notEnoughMoney=tripPrice- remainingMoney;

            if (remainingMoney >= tripPrice) Console.WriteLine($"Yes! {leftMoney:f2} lv left.");
            else Console.WriteLine($"Not enough money! {notEnoughMoney:f2} lv needed.");
        }
    }
}
