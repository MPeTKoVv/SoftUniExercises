using System;
using System.Collections.Generic;

namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cnt = int.Parse(Console.ReadLine());

            SortedSet<string> elements = new SortedSet<string>();

            for (int i = 0; i < cnt; i++)
            {
                string[] chemicalCompound = Console.ReadLine().Split();

                for (int j = 0; j < chemicalCompound.Length; j++)
                {
                    if (!elements.Contains(chemicalCompound[j]))
                    {
                        elements.Add(chemicalCompound[j]);
                    }
                }
            }

            Console.WriteLine(String.Join(" ", elements));
        }
    }
}
