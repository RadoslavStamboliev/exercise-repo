using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            while (number%2==0)
            {
                Console.WriteLine("Please write an odd number.");
                number= int.Parse(Console.ReadLine());
            }
            if (number<0)
            {
                Console.WriteLine($"The number is: {-number}");
            }
            else
            {
                Console.WriteLine($"The number is: {number}");
            }
           
        }
    }
}
