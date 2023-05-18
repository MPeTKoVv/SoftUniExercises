using System;

namespace _04._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (string bannedWord in bannedWords)
            {
                string replacedWithAsteriks = new string('*', bannedWord.Length);

                text = text.Replace(bannedWord, replacedWithAsteriks);
            }

            Console.WriteLine(text);

        }
    }
}
