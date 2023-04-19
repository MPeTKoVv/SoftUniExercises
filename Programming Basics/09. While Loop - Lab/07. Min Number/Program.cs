using System;

namespace _07._Min_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int minNum = int.MaxValue;
            while (input != "Stop")
            {
                int inputAsNumber = int.Parse(input);
                if (inputAsNumber < minNum)
                {
                    minNum = inputAsNumber;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(minNum);
        }
    }
}
