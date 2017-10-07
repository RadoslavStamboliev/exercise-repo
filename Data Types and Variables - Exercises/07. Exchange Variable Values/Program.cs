using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Before:\r\na = {a}\nb = {b}");
            int reminder = a;
            a = b;
            b = reminder;
            Console.WriteLine($"After:\r\na = {a}\nb = {b}");
          
        }
    }
}
