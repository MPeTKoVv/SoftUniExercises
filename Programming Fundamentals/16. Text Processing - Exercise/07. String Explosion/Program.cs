using System;

namespace _07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string explosions = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i]=='>')
                {
                    explosions += text[i + 1];
                }
            }

            for (int i = 0; i < explosions.Length; i++)
            {
                text = text.Remove((text[explosions[i]], explosions[i]));
            }

            Console.WriteLine(text);
        }
    }
}
