using System;
using System.Diagnostics.Metrics;

namespace Assg_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        void Start()
        {
            Console.Write("Enter book title: ");
            string title = Console.ReadLine();

            Console.Write("Enter book author: ");
            string author = Console.ReadLine();

            Book book1 = new Book(title, author);

            Console.WriteLine("");
            Console.WriteLine("Book details:");
            Console.WriteLine($"Title: {book1.Title}");
            Console.WriteLine($"Author: {book1.Author}");
        }
    }
}
