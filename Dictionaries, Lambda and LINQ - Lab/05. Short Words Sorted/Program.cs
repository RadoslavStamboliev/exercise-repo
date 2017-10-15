using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separator = new char[]
            {'.',',',':',';','(',')','[',']','\\','\"','\'','/','!','?',' '};
            var nums = Console.ReadLine().ToLower()
                .Split(separator,StringSplitOptions.RemoveEmptyEntries)
                .Where(num=>num.Length<5)
                .OrderBy(num=>num)
                .Distinct();
            Console.WriteLine(string.Join(", ", nums));

        }
    }
}

