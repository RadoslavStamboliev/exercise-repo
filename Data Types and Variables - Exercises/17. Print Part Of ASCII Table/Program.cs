using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte first = sbyte.Parse(Console.ReadLine());
            sbyte second = sbyte.Parse(Console.ReadLine());
            for (sbyte i = first; i <= second; i++)
            {
                Console.Write(Convert.ToChar(i)+" ");
            }
            Console.WriteLine();
        }
    }
}
