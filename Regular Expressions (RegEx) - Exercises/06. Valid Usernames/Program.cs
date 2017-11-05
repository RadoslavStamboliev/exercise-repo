using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var usernames = Console.ReadLine()
                .Split("\\ /()".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();
            var pattern = @"^[a-zA-Z][a-zA-Z\d_]{2,24}$";
            var validUsernames=new List<string>();
            foreach (var username in usernames)
            {
                var match = Regex.Match(username, pattern);

                if (match.Success)
                {
                    validUsernames.Add(username);
                }
            }

            var maxLenght = 0;
            var bestIndex = 0;
            for (int i = 0; i < validUsernames.Count - 1; i++)
            {
                var currentUsernameLenght = validUsernames[i].Length;
                var nextUsernameLenght = validUsernames[i + 1].Length;

                if (currentUsernameLenght+nextUsernameLenght>maxLenght)
                {
                    maxLenght = currentUsernameLenght + nextUsernameLenght;
                    bestIndex = i;
                }
            }
            Console.WriteLine(validUsernames[bestIndex]);
            Console.WriteLine(validUsernames[bestIndex+1]);
        }
    }
}
