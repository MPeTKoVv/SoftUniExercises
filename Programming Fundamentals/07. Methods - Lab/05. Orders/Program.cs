using System;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string order = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            Price(order, quantity);
        }

        private static void Price(string order, int quantity)
        {
            double price = 0;

            switch (order)
            {
                case "coffee":
                    price = 1.5;
                    break;
                case "water":
                    price = 1;
                    break;
                case "coke":
                    price = 1.4;
                    break;
                case "snacks":
                    price = 2;
                    break;
            }

            double totalPrice = quantity * price;

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
