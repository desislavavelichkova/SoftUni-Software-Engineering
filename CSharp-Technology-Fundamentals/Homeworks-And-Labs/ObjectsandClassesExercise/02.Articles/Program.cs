using System;

namespace _02.Articles
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] tokens = Console.ReadLine()
                              .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Article article = new Article(tokens[0], tokens[1], tokens[2]);

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmdArg = Console.ReadLine().Split(": ");
                string comand = cmdArg[0];
                string argument = cmdArg[1];

                switch (comand)
                {
                    case "Edit":
                        article.Edit(argument);
                        break;

                    case "ChangeAuthor":
                        article.ChangeAutor(argument);
                        break;

                    case "Rename":
                        article.Rename(argument);
                        break;
                }  
            }
                Console.WriteLine(article.ToString());
        }
    }

    class Article
    {
        public Article(string title, string content, string autor)
        {
            Title = title;
            Content = content;
            Autor = autor;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Autor { get; set; }

        public void Edit (string content)
        {
            Content = content;
        }

        public void ChangeAutor (string autor)
        {
            Autor = autor;
        }

        public void Rename(string title)
        {
            Title = title;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Autor}";
        }
    }
}
