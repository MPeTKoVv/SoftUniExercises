using System;

namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string substringToRemove = Console.ReadLine();
            string input = Console.ReadLine();


            while (input.Contains(substringToRemove))
            {
                int startIndex = input.IndexOf(substringToRemove);

                input = input.Remove(startIndex, substringToRemove.Length);
            }

            Console.WriteLine(input);
        }
    }
}
