using System;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            SearchForVoweles(input);
        }

        private static void SearchForVoweles(string input)
        {
            int cnt = 0;

            foreach (char vowel in input)
            {
                if ("aouei".Contains(vowel))
                {
                    cnt++;
                }
            }

            Console.WriteLine(cnt);
        }
    }
}
