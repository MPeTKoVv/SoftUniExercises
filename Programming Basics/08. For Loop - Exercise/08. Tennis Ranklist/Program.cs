using System;

namespace _08._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            double pointsFromInput = double.Parse(Console.ReadLine());
            double totalPoints = pointsFromInput;
            double pointsFromMaches = 0;
            double winnedGames = 0;
            for (int counter = 0; counter < tournaments; counter++)
            {
                string level = Console.ReadLine();
                if (level == "W")
                {
                    pointsFromMaches += 2000;
                    winnedGames++;
                }
                else if (level == "F")
                {
                    pointsFromMaches += 1200;
                }
                else if (level == "SF")
                {
                    pointsFromMaches += 720;
                }
            }
            totalPoints += pointsFromMaches;
            double average = Math.Floor(pointsFromMaches / tournaments);

            Console.WriteLine($"Final points: {totalPoints}");
            Console.WriteLine($"Average points: {average}");
            Console.WriteLine($"{winnedGames / tournaments * 100:f2}% ");
        }
    }
}
