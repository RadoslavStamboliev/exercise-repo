using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_is_your_name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What's your name? ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
