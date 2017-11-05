using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _2.Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("input.txt");
            var numberedLines=lines.Select((line,index)=>$"{index+1}. {line}");
            File.WriteAllLines("output.txt",numberedLines);
        }
    }
}
