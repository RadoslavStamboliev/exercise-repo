using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string regex = @"\+359(\s|-)2\1\d{3}\1\d{4}\b";

            MatchCollection phoneMatches = Regex.Matches(input, regex);

            var result = phoneMatches.Cast<Match>().Select(x => x.ToString()).ToArray();


            Console.Write(string.Join(", ", result));
        }
    }
}
