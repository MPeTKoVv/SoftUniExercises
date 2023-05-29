using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = int.Parse(Console.ReadLine());

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < value; i++)
            {
                int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int amount = array[0];
                int distance = array[1];

                queue.Enqueue(amount);
            }

            Console.WriteLine(queue.Min());
        }
    }
}
