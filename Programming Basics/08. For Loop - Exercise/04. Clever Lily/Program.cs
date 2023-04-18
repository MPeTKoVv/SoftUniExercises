using System;

namespace _04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            decimal wasingMachinePrice = decimal.Parse(Console.ReadLine());
            decimal priceForOneToy = decimal.Parse(Console.ReadLine());
            int toysCollected = 0;
            int moneyCollected = 0;

            for (int counter = 1; counter <= age; counter++)
            {
                if (counter % 2 != 0) toysCollected++;
                else moneyCollected += 5 * counter - 1;
            }
            decimal moneyFromSelledToys = priceForOneToy * toysCollected;
            decimal totalMoney = moneyFromSelledToys + moneyCollected;
            decimal leftMoney = totalMoney - wasingMachinePrice;
            decimal neededMoney = wasingMachinePrice - totalMoney;

            if (totalMoney >= wasingMachinePrice) Console.WriteLine($"Yes! {leftMoney:f2}");
            else Console.WriteLine($"No! {neededMoney:f2}");
        }
    }
}
/*
             using System;
 
namespace P04.CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int n = int.Parse(Console.ReadLine());
            double washerPrice = double.Parse(Console.ReadLine());
            int singleToyPrice = int.Parse(Console.ReadLine());
 
            //Act
            //Let the for loop be Lily aging
            int toysCollected = 0;
            int savings = 0;
            //int moneyGift = 10;
 
            for (int currAge = 1; currAge <= n; currAge++)
            {
                //Single iteration represent signle year of Lily's life
                if (currAge % 2 != 0)
                {
                    //Odd age
                    toysCollected++;
                }
                else
                {
                    //Even age
                    //For every year * 5 leva and minus 1 leva for her brother
                    int moneyPresent = (currAge * 5) - 1;
                    //moneyPresent -= 1;
                    //moneyPresent--;
                    //int moneyPresent = moneyGift - 1;
                    //moneyGift += 10;
                    savings += moneyPresent;
                }
            }
 
            //Lily has saved money from even years
            //Now we need to add the money from the sold toys
            int toysSellPrice = toysCollected * singleToyPrice;
            savings += toysSellPrice;
 
            //Output
            if (savings >= washerPrice)
            {
                double left = savings - washerPrice;
                Console.WriteLine($"Yes! {left:f2}");
            }
            else
            {
                double moneyNeeded = washerPrice - savings;
                Console.WriteLine($"No! {moneyNeeded:f2}");
            }
        }
    }
}
            */