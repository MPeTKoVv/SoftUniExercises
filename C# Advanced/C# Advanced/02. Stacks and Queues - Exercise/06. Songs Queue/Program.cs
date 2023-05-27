using System;
using System.Collections.Generic;

namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            Queue<string> songs = new Queue<string>(input);

            while (songs.Count > 0)
            {
                string command = Console.ReadLine();

                string token = command[0];

                if (token == "Play")
                {
                    songs.Dequeue();
                }
                else if (token == "Add")
                {
                    //string song = command[]

                    //if (songs.Contains(song))
                    //{
                    //    Console.WriteLine($"{song} is already contained!");
                    //}
                    //else
                    //{
                    //    songs.Enqueue(song);
                    //}
                }
                else if (token == "Show")
                {
                    Console.WriteLine(String.Join(", ", songs));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
