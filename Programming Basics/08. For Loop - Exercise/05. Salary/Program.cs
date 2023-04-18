using System;

namespace _05._Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int counter = 1; counter <= n; counter++)
            {
                string currentTamWebsite = Console.ReadLine();
                if (currentTamWebsite == "Facebook")
                {
                    salary -= 150;
                }
                else if (currentTamWebsite == "Instagram")
                {
                    salary -= 100;
                }
                else if (currentTamWebsite == "Reddit")
                {
                    salary -= 50;
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }
            }
            Console.WriteLine(salary);

        }
    }
}
