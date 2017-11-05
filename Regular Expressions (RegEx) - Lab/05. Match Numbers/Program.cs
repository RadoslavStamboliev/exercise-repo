using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbersStrings = Console.ReadLine();
            string regex = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            var numbers = Regex.Matches(numbersStrings, regex);
            foreach (Match number in numbers)
            {
                Console.Write(number.Value+" ");
            }
            Console.WriteLine();
        }
    }
}
