using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());
            int dayCnt = 0;
            int spendingCnt = 0;
            int spendCnt = 0;
            bool isSheSpendingFiveDays = false;

            while (ownedMoney < neededMoney)
            {
                dayCnt++;
                string action = Console.ReadLine();
                double currentMoney = double.Parse(Console.ReadLine());

                if (action == "spend")
                {
                    spendCnt++;
                    if (currentMoney > ownedMoney)
                    {
                        ownedMoney = 0;
                    }
                    else
                    {
                        ownedMoney -= currentMoney;
                    }
                }
                else if (action == "save")
                {
                    ownedMoney += currentMoney;

                    if (ownedMoney >= neededMoney)
                    {
                        break;
                    }
                    spendCnt = 0;
                }

                if (spendCnt >= 5)
                {
                    break;
                }

            }
            if (spendCnt>=5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(dayCnt);
            }
            else
            {
                Console.WriteLine($"You saved the money for {dayCnt} days.");
            }
        }
    }
}
