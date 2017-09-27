using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int times = 1;
            while (times<=10)
            {
                Console.WriteLine($"{number} X {times} = {number*times}");
                times++;
            }
        }
    }
}
