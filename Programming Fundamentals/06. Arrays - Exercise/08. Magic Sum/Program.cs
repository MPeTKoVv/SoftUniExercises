using System;
using System.Linq;

namespace _08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = int.Parse(Console.ReadLine());

            for (var num1 = 0; num1 < numbers.Length; num1++)
            {
                for (var num2 = num1 + 1; num2 < numbers.Length; num2++)
                {
                    if (numbers[num1] + numbers[num2] == sum)
                    {
                        Console.WriteLine($"{numbers[num1]} {numbers[num2]}");
                    }
                }
            }
        }
    }
}
