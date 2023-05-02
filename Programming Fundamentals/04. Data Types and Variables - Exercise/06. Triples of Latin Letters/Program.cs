using System;

namespace _06._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = 96 + startNum;

            for (int i = 97; i <= endNum; i++)
            {
                for (int j = 97; j <= endNum; j++)
                {
                    for (int k = 97; k <= endNum; k++)
                    {
                        Console.WriteLine($"{(char)i}{(char)j}{(char)k}");
                    }
                }
            }
        }
    }
}
