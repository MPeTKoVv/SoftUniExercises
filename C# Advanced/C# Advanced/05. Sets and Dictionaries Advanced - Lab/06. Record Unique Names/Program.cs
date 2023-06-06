using System;
using System.Collections.Generic;

namespace _06._Record_Unique_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string>();

            int cnt = int.Parse(Console.ReadLine());

            for (int i = 0; i < cnt; i++)
            {
                string currName = Console.ReadLine();

                names.Add(currName);
            }

            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
