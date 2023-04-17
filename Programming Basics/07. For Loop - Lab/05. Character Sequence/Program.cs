using System;

namespace _05._Character_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word=Console.ReadLine();
            int lengthOfWord=word.Length;
            for (int index = 0; index < lengthOfWord; index++)
            {
                char currentChar = word[index];
                Console.WriteLine(currentChar);
            }
        }
    }
}
