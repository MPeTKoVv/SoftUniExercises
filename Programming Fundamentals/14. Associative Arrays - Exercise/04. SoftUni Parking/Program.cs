using System;
using System.Collections.Generic;

namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var registerdUsers = new Dictionary<string, string>();

            int counts = int.Parse(Console.ReadLine());

            for (int i = 0; i < counts; i++)
            {
                var input = Console.ReadLine().Split();

                var action = input[0];
                var username = input[1];

                if (action == "register")
                {
                    var licensePlateNumber = input[2];

                    if (registerdUsers.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                    else
                    {
                        registerdUsers.Add(username, licensePlateNumber);
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                }
                else if (action == "unregister")
                {
                    if (!registerdUsers.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        registerdUsers.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }

            foreach (var item in registerdUsers)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
