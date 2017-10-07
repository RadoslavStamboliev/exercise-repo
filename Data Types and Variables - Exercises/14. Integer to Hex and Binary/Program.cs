using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
            var numberInBinary = Convert.ToString(number, 2);
            var numberInHexaint = Convert.ToString(number,16).ToUpper();
            Console.WriteLine(numberInHexaint);
            Console.WriteLine(numberInBinary);
        }
    }
}
