using System;

namespace _02._Bonus_Score
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double bonus;
            if (number <= 100)
            {
                bonus = 5;
            }
            else if (number > 100 && number < 1000)
            {
                bonus = 0.2 * number;
            }
            else
            {
                bonus = 0.1 * number;
            }
            if (number%2==0)
            {
                bonus += 1;
            }
            else if (number%5==0)
            {
                bonus += 2;
            }
            else
            {
                bonus += 0;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(bonus + number);
        }
    }
}
