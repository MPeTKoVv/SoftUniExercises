using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            int cnt = int.Parse(Console.ReadLine());

            Queue<string> players = new Queue<string>(names);

            while (players.Count > 1)
            {
                for (int i = 0; i < cnt - 1; i++)
                {
                    players.Enqueue(players.Dequeue());
                }

                Console.WriteLine($"Removed {players.Dequeue()}");
            }

            Console.WriteLine($"Last is {players.Peek()}");
        }
    }
}
