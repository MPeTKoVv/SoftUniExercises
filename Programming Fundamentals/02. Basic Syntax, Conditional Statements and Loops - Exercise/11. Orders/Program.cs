using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());

            double price = 0;
            double totalPrice = 0;

            for (int i = 0; i < orders; i++)
            {

                double capsulePrice = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());

                price = (days * capsulesCount) * capsulePrice;
                totalPrice += price;

                Console.WriteLine($"The price for the coffee is: ${price:f2}");

            }

            Console.WriteLine($"Total: ${totalPrice:f2}");

        }
    }
}

