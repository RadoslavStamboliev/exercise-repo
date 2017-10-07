using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterNumberSystems
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var decimalNumber = Convert.ToString(number, 2);
            Console.WriteLine(decimalNumber);
        }
    }
}
