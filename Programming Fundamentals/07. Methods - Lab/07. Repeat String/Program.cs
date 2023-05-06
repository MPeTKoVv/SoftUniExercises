using System;

namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int repeatedTimes = int.Parse(Console.ReadLine());

            Repeat(input, repeatedTimes);
        }

        private static void Repeat(string input, int repeatedTimes)
        {
            for (int i = 0; i < repeatedTimes; i++)
            {
                Console.Write(input);
            }
        }
    }
}
