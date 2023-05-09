using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToList();

            int originalLenght = numbers.Count;

            for (int i = 0; i < originalLenght / 2; i++)
            {
                numbers[i] += numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
