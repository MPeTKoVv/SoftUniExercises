using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string correctpassword = "";

            for (int i = username.Length - 1; i >= 0; i--)
            {
                correctpassword += username[i];
            }

            string password = Console.ReadLine();

            int cnt = 0;

            while (password != correctpassword)
            {
                cnt++;
                if (cnt == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");
                password = Console.ReadLine();
            }

            Console.WriteLine($"User {username} logged in.");
        }
    }
}
