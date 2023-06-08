using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cnt = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> studentGrades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < cnt; i++)
            {
                string[] currStudent = Console.ReadLine().Split();
                string currName = currStudent[0];
                decimal currGrade = decimal.Parse(currStudent[1]);

                if (!studentGrades.ContainsKey(currName))
                {
                    studentGrades.Add(currName, new List<decimal>());
                }

                studentGrades[currName].Add(currGrade);
            }

            foreach (KeyValuePair<string, List<decimal>> item in studentGrades)
            {
                Console.Write($"{item.Key} -> ");

                foreach (decimal grade in item.Value)
                {
                    Console.Write($"{grade:f2} ");
                }

                Console.WriteLine($"(avg: {item.Value.Average():f2})");
            }
        }
    }
}
