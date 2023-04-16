using System;

namespace _08._On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startHour = int.Parse(Console.ReadLine());
            int startMinute = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinute = int.Parse(Console.ReadLine());

            if (arriveHour * 60 + arriveMinute - (startHour * 60 + startMinute) > 0)
            {
                int time = arriveHour * 60 + arriveMinute - (startHour * 60 + startMinute);
                int hour = time / 60;
                int minute = time % 60;
                Console.WriteLine("Late");

                if (minute == 0)
                {
                    Console.WriteLine($"{hour} 00 hours after the start");
                }
                else if (minute < 10 && hour >= 1)
                {
                    Console.WriteLine($"{hour}:0{minute} hours after the start");
                }
                else if (hour >= 1)
                {
                    Console.WriteLine($"{hour}:{minute} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{minute} minutes after the start");
                }
            }
            else if (startHour * 60 + startMinute == arriveHour * 60 + arriveMinute)
            {
                Console.WriteLine("On time");
            }
            else if (startHour * 60 + startMinute - (arriveHour * 60 + arriveMinute) <= 30)
            {
                Console.WriteLine("On time");
                int time = startHour * 60 + startMinute - (arriveHour * 60 + arriveMinute);
                int hour = time / 60;
                int minute = time % 60;
                Console.WriteLine($"{minute} minutes before the start");
            }

            else if (startHour * 60 + startMinute - (arriveHour * 60 + arriveMinute) > 30)
            {
                int time = startHour * 60 + startMinute - (arriveHour * 60 + arriveMinute);
                int hour = time / 60;
                int minute = time % 60;
                Console.WriteLine("Early");

                if (minute == 0)
                {
                    Console.WriteLine($"{hour} 00 hours before the start");
                }
                else if (minute < 10 && hour >= 1)
                {
                    Console.WriteLine($"{hour}:0{minute} hours before the start");
                }
                else if (hour >= 1)
                {
                    Console.WriteLine($"{hour}:{minute} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{minute} minutes before the start");
                }
            }
        }
    }
}
