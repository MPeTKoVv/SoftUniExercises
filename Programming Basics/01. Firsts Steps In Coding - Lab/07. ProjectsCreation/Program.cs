using System;

namespace T07._Projects_Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name=Console.ReadLine();
            int projects=int.Parse(Console.ReadLine());
            int hours = 3;
            int work = projects * hours;
            Console.WriteLine($"The architect {name} will need {work} hours to complete {projects} project/s.");
        }
    }
}
