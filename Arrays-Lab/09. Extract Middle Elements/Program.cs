﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            typeSelector(array);

        }

        static void typeSelector(int[] ar)
        {
            int n = ar.Length;
            if (n == 1)
            {
                One(ar);
            }
            else if (n % 2 == 0)
            {
                Even(ar);
            }
            else
            {
                Odd(ar);
            }
        }
        static void One(int[] arr)
        {
            Console.WriteLine(arr[0]);
        }

        static void Even(int[] arr)
        {
            Console.WriteLine($"{arr[arr.Length / 2 - 1]}, {arr[arr.Length / 2]}");
        }

        static void Odd(int[] arr)
        {
            Console.WriteLine($"{arr[arr.Length / 2 - 1]}, {arr[arr.Length / 2]}, {arr[arr.Length / 2 + 1]}");
        }
    }
}
