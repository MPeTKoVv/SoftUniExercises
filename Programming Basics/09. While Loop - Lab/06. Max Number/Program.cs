using System;

namespace _06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int maxNum = int.MinValue;
            while (input != "Stop")
            {
                int inputAsNumber = int.Parse(input);
                if (inputAsNumber > maxNum)
                {
                    maxNum = inputAsNumber;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(maxNum);
        }
    }
}
