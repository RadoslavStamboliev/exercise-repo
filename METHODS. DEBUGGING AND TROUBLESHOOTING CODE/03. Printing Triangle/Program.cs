using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Printing_Triangle
{
    class Program
    {
        static void prinLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void printTriangle(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                prinLine(1,i);
            }
            for (int i = n-1; i >= 0; i--)
            {
                prinLine(1, i);
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            printTriangle(n);
        }
    }
}
