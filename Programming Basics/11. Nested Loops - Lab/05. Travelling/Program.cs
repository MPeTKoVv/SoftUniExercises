using System;

namespace _05._Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            bool isColect = false;

            while (destination != "End")
            {
                double budget = double.Parse(Console.ReadLine());
                double savedMoney = 0;
                while (savedMoney < budget)
                {
                    double currentMoney = double.Parse(Console.ReadLine());
                    savedMoney += currentMoney;
                    if (savedMoney >= budget)
                    {
                        isColect = true;
                        break;
                    }
                }
                if (isColect)
                {
                    Console.WriteLine($"Going to {destination}!");
                    isColect = false;
                }
                destination = Console.ReadLine();
            }
        }
    }
}
