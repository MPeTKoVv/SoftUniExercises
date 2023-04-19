using System;

namespace _05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            string input = Console.ReadLine();

            while (input != "NoMoreMoney")
            {
                if (input == "NoMoreMoney")
                {
                    break;
                }
                double inputAsNumber = double.Parse(input);
                if (inputAsNumber < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                total += inputAsNumber;
                Console.WriteLine($"Increase: {inputAsNumber:f2}");
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {total:f2}");
        }
    }
}
