using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int seconfNum = int.Parse(Console.ReadLine());


            for (int i = firstNum; i <= seconfNum; i++)
            {
                int evenSum = 0;
                int oddSum = 0;
                int currentNum = i;
                int cnt = 0;

                while (currentNum > 0)
                {
                    if (cnt % 2 == 0)
                    {
                        evenSum += currentNum % 10;
                        currentNum = currentNum / 10;
                    }
                    else
                    {
                        oddSum += currentNum % 10;
                        currentNum = currentNum / 10;
                    }
                    cnt++;
                }
                if (evenSum == oddSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
