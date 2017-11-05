using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string pattern = @"\b[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]*\b";
            foreach (Match m in Regex.Matches(name, pattern))
            {
                Console.Write(m.Value+" ");
            }
            Console.WriteLine();
        }
    }
}
