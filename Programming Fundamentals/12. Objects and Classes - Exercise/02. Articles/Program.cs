using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata;

namespace _02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] articleElements = Console.ReadLine().Split(", ").ToArray();

            string title = articleElements[0];
            string content = articleElements[1];
            string author = articleElements[2];

            Article article = new Article(title, content, author);

            int commands = int.Parse(Console.ReadLine());

            for (int i = 0; i < commands; i++)
            {
                string[] command = Console.ReadLine().Split(": ").ToArray();
                string action = command[0];
                string newElement = command[1];

                if (action == "Edit")
                {
                    article.Edit(newElement);
                }
                else if (action == "ChangeAuthor")
                {
                    article.ChangeAuthor(newElement);
                }
                else if (action == "Rename")
                {
                    article.Rename(newElement);
                }
            }

            Console.WriteLine(article.ToString());
        }
    }

    public class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;

        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit(string newContent)
        {
            Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void Rename(string newTitle)
        {
            Title = newTitle;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}