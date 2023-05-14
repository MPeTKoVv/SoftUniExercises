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
            List<Article> articles = new List<Article>();

            int articlesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < articlesCount; i++)
            {
                string[] articleElements = Console.ReadLine().Split(", ").ToArray();

                string title = articleElements[0];
                string content = articleElements[1];
                string author = articleElements[2];

                Article article = new Article(title, content, author);

                articles.Add(article);
            }
            foreach (var article in articles)
            {
                Console.WriteLine(article.ToString());
            }
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