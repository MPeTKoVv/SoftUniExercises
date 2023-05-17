using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();

            string word = Console.ReadLine();

            while (word != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(word))
                {
                    resources.Add(word, 0);
                }

                resources[word] += quantity;

                word = Console.ReadLine();
            }

            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
