using System;

namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string searchedBook = Console.ReadLine();
            int checkedBooks = 0;
            string currentBook;
            while ((currentBook = Console.ReadLine()) != searchedBook)
            {
                if (currentBook == "No More Books")
                {
                    break;
                }
                checkedBooks++;
            }
            if (currentBook == searchedBook)
            {
                Console.WriteLine($"You checked {checkedBooks} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {checkedBooks} books.");
            }
        }
    }
}
