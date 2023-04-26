using System;

namespace _11._Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int num1 = int.Parse(Console.ReadLine());

            if (num1>10)
            {
                Console.WriteLine($"{num} X {num1} = {num*num1}");
            }

            for (int i = num1; i <= 10; i++)
            {
                Console.WriteLine($"{num} X {i} = {num * i}");
            }
        }
    }
}
