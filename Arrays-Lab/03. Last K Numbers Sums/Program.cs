﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long[] sequence = new long[n];
            sequence[0] = 1;
            for (int i = 1; i < n; i++)
            {
                long result = 0;
                for (int j = i - 1; j >= 0 && j >= i - k; j--)
                {
                    result = result + sequence[j];
                }
                sequence[i] = result;
            }
            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
