using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<=\s|^)([a-z0-9]+(?:[_.-][a-z0-9]+)*@(?:[a-z]+\-?[a-z]+\.)+[a-z]+\-?[a-z]+)\b";
            foreach (Match match in Regex.Matches(input, pattern))
            {
                Console.WriteLine(match.Value);
            }
            Console.WriteLine();
            //string text = Console.ReadLine();
            //string pattern = @"([w\,-]+\@[a-zA-z-]+)(\.[a-zA-Z-]+)+";
            //Regex regex = new Regex(pattern);
            //MatchCollection matches = regex.Matches(text);
            //foreach (var emailMatch in matches)
            //{
            //    string email = emailMatch.ToString();
            //    if (!(email.StartsWith(".") || email.StartsWith("-") || email.StartsWith("_") || email.EndsWith(".") || email.EndsWith("-") || email.EndsWith("_")))
            //    {
            //        Console.WriteLine(emailMatch);
            //    }
            //}
        }
    }
}
