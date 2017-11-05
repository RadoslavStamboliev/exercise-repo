using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Book_Library_Modification
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

        public class BookLibraryModification
        {
            public static void Main()
            {
                List<Book> books = GetBooks();
                DateTime targetReleaseDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

                string[] titlesReleasedAfterDate = books.Where(x => x.ReleaseDate > targetReleaseDate)
                    .OrderBy(x => x.ReleaseDate).ThenBy(x => x.Title)
                    .Select(x => x.Title).Distinct()
                    .ToArray();

                foreach (string title in titlesReleasedAfterDate)
                {
                    DateTime[] bookReleaseDates =
                        books.Where(x => x.Title == title && x.ReleaseDate > targetReleaseDate)
                            .OrderBy(x => x.ReleaseDate).Select(x => x.ReleaseDate).Distinct().ToArray();
                    foreach (DateTime bookReleaseDate in bookReleaseDates)
                    {
                        Console.WriteLine("{0} -> {1:dd.MM.yyyy}", title, bookReleaseDate);
                    }
                }
            }
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
