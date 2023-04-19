using System;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int badGrades = 0;
            int classCnt = 0;
            double gradeSum = 0;
            bool isThePersonExcluded = false;
            double averageGrade = 0;
            while (classCnt < 12)
            {
                classCnt++;
                double grade = double.Parse(Console.ReadLine());
                if (grade < 4)
                {
                    badGrades++;
                }
                if (badGrades == 2)
                {
                    classCnt--;
                    isThePersonExcluded = true;
                    break;
                }
                gradeSum += grade;
                averageGrade = gradeSum / classCnt;
            }
            if (isThePersonExcluded)
            {
                Console.WriteLine($"{name} has been excluded at {classCnt} grade");
            }
            else
            {
                Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
            }
        }
    }
}
