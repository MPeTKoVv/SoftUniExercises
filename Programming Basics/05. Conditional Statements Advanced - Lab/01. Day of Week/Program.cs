using System;

namespace _01._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayOfWeek = int.Parse(Console.ReadLine());

            /*
            if (dayOfWeek == 1) Console.WriteLine("Monday");
            else if (dayOfWeek == 2) Console.WriteLine("Tuesday");
            else if (dayOfWeek == 3) Console.WriteLine("Wednesday");
            else if (dayOfWeek == 4) Console.WriteLine("Thursday");
            else if (dayOfWeek == 5) Console.WriteLine("Friday");
            else if (dayOfWeek == 6) Console.WriteLine("Saturday");
            else if (dayOfWeek == 7) Console.WriteLine("Sunday");
            else Console.WriteLine("Error");
            */

            switch (dayOfWeek)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
