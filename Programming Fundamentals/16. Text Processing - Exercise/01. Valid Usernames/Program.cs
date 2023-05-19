using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            List<string> validUsernames = new List<string>();
            bool IsValid = true;

            foreach (var username in usernames)
            {
                IsValid = true;

                if (username.Length >= 3 && username.Length <= 16)
                {
                    foreach (char item in username)
                    {
                        if (!(item == '-' || item == '_' || char.IsLetterOrDigit(item)))
                        {
                            IsValid = false;
                            break;
                        }
                    }

                    if (IsValid)
                    {
                        validUsernames.Add(username);
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, validUsernames));
        }
    }
}
