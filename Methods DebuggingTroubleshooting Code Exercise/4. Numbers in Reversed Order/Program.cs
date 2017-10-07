using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Numbers_in_Reversed_Order
{
    class Program
    {
        static void printTheDigitsInReversedOrder(string a)
        {
            for (int i = a.Length-1;i >= 0; i--)
            {
                Console.Write(a[i]);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            printTheDigitsInReversedOrder(number);
        }
    }
}
