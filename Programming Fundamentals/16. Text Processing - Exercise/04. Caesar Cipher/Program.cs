using System;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string cipheredText = "";

            for (int i = 0; i < input.Length; i++)
            {
                cipheredText += (char)(input[i] + 3);
            }

            Console.WriteLine(cipheredText);
        }
    }
}
