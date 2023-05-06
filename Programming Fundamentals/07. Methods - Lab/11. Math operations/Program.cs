using System;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(num1, operation, num2));
        }

        static double Calculate(double num1, string operation, double num2)
        {
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
            }

            return result;
        }
    }
}
