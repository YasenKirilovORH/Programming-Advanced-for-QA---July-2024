using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace _02.Articles
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] articleInformation = Console.ReadLine().Split(", ");

            string title = articleInformation[0];
            string content = articleInformation[1];
            string author = articleInformation[2];

            Article article = new Article(title, content, author);

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int count = 0; count < numberOfCommands; count++)
            {
                string[] input = Console.ReadLine().Split(": ");

                string command = input[0];
                string newText = input[1];

                switch (command)
                {
                    case "Edit":
                        article.Edit(newText);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(newText);
                        break;
                    case "Rename":
                        article.Rename(newText);
                        break;
                }
            }
            Console.WriteLine(article.ToString());
        }
    }

    class Article
    {
        public string Title { get; private set; }
        public string Content { get; private set; }
        public string Author { get; private set; }

        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

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
