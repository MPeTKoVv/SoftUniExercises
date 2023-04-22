using System;

namespace _04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int judgesAmount = int.Parse(Console.ReadLine());
            string presentaionName = Console.ReadLine();
            double studentsScore = 0;
            int cnt = 0;

            while (presentaionName != "Finish")
            {
                cnt++;
                double averageScore = 0;

                for (int i = 0; i < judgesAmount; i++)
                {
                    double great = double.Parse(Console.ReadLine());
                    averageScore += great;
                }
                averageScore /= judgesAmount;
                studentsScore += averageScore;
                Console.WriteLine($"{presentaionName} - {averageScore:f2}.");
                presentaionName = Console.ReadLine();
            }
            double averageStudentsScore = studentsScore / cnt;
            Console.WriteLine($"Student's final assessment is {averageStudentsScore:f2}.");
        }
    }
}
