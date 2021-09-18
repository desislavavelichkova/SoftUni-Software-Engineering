using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(", ");
                string title = tokens[0];
                string content = tokens[1];
                string author = tokens[2];

                Article article = new Article(title, content, author);
                articles.Add(article);
                
            }
            string criteia = Console.ReadLine();

            if (criteia == "title")
            {
                 articles = articles.OrderBy(a => a.Title).ToList();
            }
            else if (criteia == "content")
            {
                articles.Sort((c1, c2) => c1.Content.CompareTo(c2.Content));
            }
            else if (criteia == "author")
            {
                articles = articles.OrderBy(a => a.Autor).ToList();
            }

            Console.WriteLine(string.Join(Environment.NewLine, articles));
        }
    }

    class Article
    {
        public Article(string title, string content, string autor) // КОНСТРУКТОР
        {
            Title = title;
            Content = content;
            Autor = autor;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Autor { get; set; }

       
        public override string ToString()
        {
            return $"{Title} - {Content}: {Autor}";
        }
    }
}
