using System;

namespace _06._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int num1 = num;

            int sum = 0;

            while (num > 0)
            {
                int factorialNum = 1;
                int currNum = num % 10;
                num /= 10;

                for (int i = 2; i <= currNum; i++)
                {
                    factorialNum *= i;
                }

                sum += factorialNum;
            }

            Console.WriteLine(sum == num1 ? "yes" : "no");
        }
    }
}
