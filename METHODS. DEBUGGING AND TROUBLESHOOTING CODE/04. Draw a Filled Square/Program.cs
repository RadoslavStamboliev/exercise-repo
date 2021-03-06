﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Draw_a_Filled_Square
{
    class Program
    {
        static void printHeaderRow(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
        static void printMiddleRow(int n)
        {
            Console.Write("-");
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            printHeaderRow(n);
            for (int i = 0; i < n - 2; i++)
            {
                printMiddleRow(n);
            }
            printHeaderRow(n);
        }
    }
}
