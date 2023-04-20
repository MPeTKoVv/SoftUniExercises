using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int failedTreshold = int.Parse(Console.ReadLine());
            int failedTimes = 0;
            int solvedProblemsCnt = 0;
            double gradeSum = 0;
            string lastProblem = string.Empty;
            bool isFailed = true;

            while (failedTimes < failedTreshold)
            {
                string taskName = Console.ReadLine();
                if (taskName == "Enough")
                {
                    isFailed = false;
                    break;
                }

                int grade = int.Parse(Console.ReadLine());

                if (grade <= 4)
                {
                    failedTimes++;
                }

                solvedProblemsCnt++;
                gradeSum += grade;
                lastProblem = taskName;
            }
            double averageScore = gradeSum / solvedProblemsCnt;

            if (isFailed)
            {
                Console.WriteLine($"You need a break, {failedTimes} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {averageScore:f2}");
                Console.WriteLine($"Number of problems: {solvedProblemsCnt}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
