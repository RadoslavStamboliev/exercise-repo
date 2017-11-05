using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Book_Library
{
    class Program
    {
        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public DateTime ReleaseDate { get; set; }
            public string ISBN { get; set; }
            public decimal Price { get; set; }
        }

        public static void Main()
        {
            List<Book> books = GetBooks();
            Dictionary<string, decimal> salesByAuthor = new Dictionary<string, decimal>();

            foreach (string author in books.Select(x => x.Author).Distinct())
                salesByAuthor.Add(author, books.Where(x => x.Author == author)
                    .Select(x => x.Price)
                    .Sum());
            foreach (var pair in salesByAuthor
                .OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                Console.WriteLine("{0} -> {1:f2}", pair.Key, pair.Value);
        }

        private static List<Book> GetBooks()
        {
            List<Book> books = new List<Book>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                books.Add(new Book()
                {
                    Title = data[0],
                    Author = data[1],
                    Publisher = data[2],
                    ReleaseDate = DateTime.ParseExact(data[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBN = data[4],
                    Price = decimal.Parse(data[5])
                });
            }
            return books;
        }
    }
}
