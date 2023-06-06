using System;
using System.Collections.Generic;

namespace _01._Unique_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cnt = int.Parse(Console.ReadLine());

            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < cnt; i++)
            {
                string curName = Console.ReadLine();

                names.Add(curName);
            }

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
