using System;

namespace _06._Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double result = 0;

            if (operation == "+")
            {
                result = n1 + n2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} {operation} {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} {operation} {n2} = {result} - odd");
                }
            }
            else if (operation == "-")
            {
                result = n1 - n2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} {operation} {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} {operation} {n2} = {result} - odd");
                }
            }
            else if (operation == "*")
            {
                result = n1 * n2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} {operation} {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} {operation} {n2} = {result} - odd");
                }
            }
            else if (operation == "/" && n2 == 0)
            {
                Console.WriteLine($"Cannot divide {n1} by zero");
            }
            else if (operation == "/")
            {
                result = n1 / n2;
                Console.WriteLine($"{n1} {operation} {n2} = {result:f2}");
            }
            else if (operation == "%" && n2 == 0)
            {
                Console.WriteLine($"Cannot divide {n1} by zero");
            }
            else if (operation == "%")
            {
                Console.WriteLine($"{n1} % {n2} = {n1 % n2}");
            }
        }
    }
}
