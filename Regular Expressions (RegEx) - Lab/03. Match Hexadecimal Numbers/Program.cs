using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbersString = Console.ReadLine();
            string regex = @"\b(?:0x)?[0-9A-F]+\b";
            var numbers = Regex.Matches(numbersString, regex).Cast<Match>().Select(a => a.Value).ToArray();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
