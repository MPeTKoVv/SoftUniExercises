using System;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            TheSmallestNum(num1, num2, num3);
        }

        static void TheSmallestNum(int num1, int num2, int num3)
        {
            int theSmallestNum = Math.Min(num1, Math.Min(num2, num3));
            Console.WriteLine(theSmallestNum);
        }
    }
}
