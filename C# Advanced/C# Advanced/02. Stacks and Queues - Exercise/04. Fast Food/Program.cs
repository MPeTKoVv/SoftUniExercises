using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> quantityOfOrders = new Queue<int>(orders);

            Console.WriteLine(quantityOfOrders.Max());


            while (quantityOfOrders.Count > 0)
            {
                if (quantity >= quantityOfOrders.Peek())
                {
                    quantity -= quantityOfOrders.Dequeue();
                }
                else
                {
                    break;
                }
            }
            if (quantityOfOrders.Count > 0)
            {
                Console.WriteLine($"Orders left: {string.Join(" ", quantityOfOrders)}");
                return;
            }
            Console.WriteLine("Orders complete");
        }
    }
}
