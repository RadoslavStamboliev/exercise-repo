using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.Use_Your_Chains__Buddy
{
    class Program
    {
        static void Main(string[] args)
        {
            var HTMLtext = Console.ReadLine();

            var pattern = @"<p>(.+?)<\/p>";
            var matches = Regex.Matches(HTMLtext, pattern);

            var currentMatch = string.Empty;

            foreach (Match match in matches)
            {
                currentMatch += match.Groups[1].Value;
            }

            currentMatch = Regex.Replace(currentMatch, @"[^a-z0-9]", " ");
            currentMatch = Regex.Replace(currentMatch, @"\s+", " ");

            var decryptedText = new StringBuilder();

            foreach (var @char in currentMatch)
            {
                var currentChar = @char;

                if (@char >= 'a' && @char <= 'm')
                {
                    currentChar = (char)(@char + 13);
                }

                else if (@char >= 'n' && @char <= 'z')
                {
                    currentChar = (char)(@char - 13);
                }

                decryptedText.Append(currentChar);
            }

            Console.WriteLine(decryptedText.ToString());
        }
    }
}
