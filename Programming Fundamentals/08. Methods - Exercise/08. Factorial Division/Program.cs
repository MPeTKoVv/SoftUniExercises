using System;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            double firstNumFavtoriel = Factoriel(firstNum);
            double secondNumFavtoriel = Factoriel(secondNum);

            PrintResult(firstNumFavtoriel, secondNumFavtoriel);
        }

        private static void PrintResult(double num1, double num2)
        {
            Console.WriteLine($"{num1 / num2:f2}");
        }

        private static double Factoriel(double number)
        {
            double result = 1;

            while (number != 1)
            {
                result *= number;
                number--;
            }

            return result;
        }
    }
}
