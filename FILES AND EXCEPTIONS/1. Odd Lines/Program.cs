using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _1.Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("lines.txt");
            var oddLines = lines.Where((line, index) => index % 2 == 1);
            File.WriteAllLines("odd-lines.txt", oddLines);
        }
    }
}
