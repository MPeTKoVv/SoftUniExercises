using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());

            Stack<int> clothesInBox = new Stack<int>(input);

            int cntRacks = 0;

            while (clothesInBox.Count > 0)
            {
                
            }
        }
    }
}
