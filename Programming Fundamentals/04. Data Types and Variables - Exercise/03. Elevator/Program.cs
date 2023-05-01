using System;

namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double persons = double.Parse(Console.ReadLine());
            //double capacity = double.Parse(Console.ReadLine());

            //double courses = Math.Ceiling(persons / capacity);

            //Console.WriteLine(courses);

            int persons = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)persons / capacity);

            Console.WriteLine(courses);
        }
    }
}
