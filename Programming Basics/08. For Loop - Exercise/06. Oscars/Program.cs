using System;

namespace _06._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double pointsFromAcademy = double.Parse(Console.ReadLine());
            double amountOfPanel = double.Parse(Console.ReadLine());
            double totalPoints = pointsFromAcademy;
            for (int counter = 1; counter <= amountOfPanel; counter++)
            {
                string appraisal = Console.ReadLine();
                double pointsFromAppraisal = double.Parse(Console.ReadLine());
                double length = appraisal.Length;
                totalPoints += pointsFromAppraisal * length / 2;
                if (totalPoints > 1250.5)
                {
                    break;
                }
            }
            if (totalPoints > 1250.5)
            {
                Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {totalPoints:f1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {name} you need {1250.5 - totalPoints:f1} more!");
            }
        }
    }
}
