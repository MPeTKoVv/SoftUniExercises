using System;

namespace _03._Sum_Prime_Non_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int nonPrimeSum = 0;
            int primeSum = 0;

            while (input != "stop")
            {
                bool isPrimeNum = false;
                int currentNum = int.Parse(input);

                if (currentNum < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    for (int i = 2; i < currentNum; i++)
                    {
                        if (currentNum % i == 0)
                        {
                            isPrimeNum = true;
                            break;
                        }
                    }
                    if (isPrimeNum)
                    {
                        nonPrimeSum += currentNum;
                    }
                    else
                    {
                        primeSum += currentNum;
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
